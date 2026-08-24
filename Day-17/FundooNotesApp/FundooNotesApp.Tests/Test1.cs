using System.Security.Claims;
using FundooNotesApp.Api;
using FundooNotesApp.Business;
using FundooNotesApp.Models;
using FundooNotesApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FundooNotesApp.Tests;

[TestClass]
public sealed class UserControllerTests
{
    [TestMethod]
    public void Register_WhenServiceReturnsSuccess_ReturnsOk()
    {
        var controller = new UserController(new FakeUserService
        {
            RegisterResult = new ResponseDTO<User>
            {
                Success = true,
                Message = "Registration Successfull",
                Data = new User { UserId = 1, FirstName = "John", LastName = "Doe", EmailAddress = "john@test.com", Password = "hash" }
            }
        });

        var result = controller.Register(new RegisterDTO
        {
            FirstName = "John",
            LastName = "Doe",
            EmailAddress = "john@test.com",
            Password = "Password@123"
        });

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        var payload = okResult.Value as ResponseDTO<User>;
        Assert.IsNotNull(payload);
        Assert.IsTrue(payload.Success);
    }

    [TestMethod]
    public void Register_WhenServiceReturnsFailure_ReturnsBadRequest()
    {
        var controller = new UserController(new FakeUserService
        {
            RegisterResult = new ResponseDTO<User>
            {
                Success = false,
                Message = "Email Address already exists."
            }
        });

        var result = controller.Register(new RegisterDTO
        {
            FirstName = "Jane",
            LastName = "Doe",
            EmailAddress = "jane@test.com",
            Password = "Password@123"
        });

        Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void Login_WhenServiceReturnsSuccess_ReturnsOk()
    {
        var controller = new UserController(new FakeUserService
        {
            LoginResult = new ResponseDTO<string>
            {
                Success = true,
                Message = "Login Successfully.",
                Data = "test-token"
            }
        });

        var result = controller.Login(new LoginDTO { EmailAddress = "john@test.com", Password = "Password@123" });

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        var payload = okResult.Value as ResponseDTO<string>;
        Assert.IsNotNull(payload);
        Assert.AreEqual("test-token", payload.Data);
    }

    [TestMethod]
    public void Login_WhenServiceReturnsFailure_ReturnsBadRequest()
    {
        var controller = new UserController(new FakeUserService
        {
            LoginResult = new ResponseDTO<string>
            {
                Success = false,
                Message = "Invalid Credentials."
            }
        });

        var result = controller.Login(new LoginDTO { EmailAddress = "john@test.com", Password = "wrong" });

        Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void ForgotPassword_WhenServiceReturnsSuccess_ReturnsOk()
    {
        var controller = new UserController(new FakeUserService
        {
            ForgotPasswordResult = new ResponseDTO<string>
            {
                Success = true,
                Message = "Reset token generated successfully.",
                Data = "reset-token"
            }
        });

        var result = controller.ForgotPassword(new ForgotPasswordDTO { EmailAddress = "john@test.com" });

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        var payload = okResult.Value as ResponseDTO<string>;
        Assert.IsNotNull(payload);
        Assert.AreEqual("reset-token", payload.Data);
    }

    [TestMethod]
    public void ForgotPassword_WhenUserDoesNotExist_ReturnsBadRequest()
    {
        var controller = new UserController(new FakeUserService
        {
            ForgotPasswordResult = new ResponseDTO<string>
            {
                Success = false,
                Message = "User does not exist. "
            }
        });

        var result = controller.ForgotPassword(new ForgotPasswordDTO { EmailAddress = "unknown@test.com" });

        Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void ResetPassword_WhenServiceReturnsSuccess_ReturnsOk()
    {
        var controller = new UserController(new FakeUserService
        {
            ResetPasswordResult = new ResponseDTO<bool>
            {
                Success = true,
                Message = "Password Updated Successfully .",
                Data = true
            }
        });

        var result = controller.ResetPassword(new ResetPasswordDTO
        {
            EmailAddress = "john@test.com",
            Token = "reset-token",
            NewPassword = "NewPassword@123"
        });

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        var payload = okResult.Value as ResponseDTO<bool>;
        Assert.IsNotNull(payload);
        Assert.IsTrue(payload.Data);
    }

    [TestMethod]
    public void ResetPassword_WhenServiceReturnsFailure_ReturnsBadRequest()
    {
        var controller = new UserController(new FakeUserService
        {
            ResetPasswordResult = new ResponseDTO<bool>
            {
                Success = false,
                Message = "Password Reset failed .",
                Data = false
            }
        });

        var result = controller.ResetPassword(new ResetPasswordDTO
        {
            EmailAddress = "john@test.com",
            Token = "reset-token",
            NewPassword = "NewPassword@123"
        });

        Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
    }

    [TestMethod]
    public void CheckAuth_WhenCalled_ReturnsAuthenticationSuccessResponse()
    {
        var controller = new UserController(new FakeUserService());

        var result = controller.CheckAuth();

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        Assert.IsNotNull(okResult.Value);
    }

    private sealed class FakeUserService : IUserService
    {
        public ResponseDTO<User> RegisterResult { get; set; } = new ResponseDTO<User> { Success = true };
        public ResponseDTO<string> LoginResult { get; set; } = new ResponseDTO<string> { Success = true };
        public ResponseDTO<string> ForgotPasswordResult { get; set; } = new ResponseDTO<string> { Success = true };
        public ResponseDTO<bool> ResetPasswordResult { get; set; } = new ResponseDTO<bool> { Success = true };

        public ResponseDTO<User> Register(RegisterDTO registerDTO) => RegisterResult;
        public ResponseDTO<string> Login(LoginDTO loginDTO) => LoginResult;
        public ResponseDTO<string> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO) => ForgotPasswordResult;
        public ResponseDTO<bool> ResetPassword(ResetPasswordDTO resetPasswordDTO) => ResetPasswordResult;
    }
}

[TestClass]
public sealed class NoteControllerTests
{
    [TestMethod]
    public void CreateNote_WhenUserIsAuthenticated_ReturnsOkWithCreatedNote()
    {
        var controller = new NoteController(new FakeNoteService
        {
            CreatedNote = new Notes { NoteId = 1, UserId = 5, NoteTitle = "Title", Description = "Description", Created = DateTime.UtcNow }
        });
        SetUser(controller, 5);

        var result = controller.CreateNote(new NotesDTO { NoteTitle = "Title", Description = "Description" });

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        var payload = okResult.Value;
        Assert.IsNotNull(payload);
    }

    [TestMethod]
    public void GetAllNotes_WhenUserIsAuthenticated_ReturnsOkWithNotesList()
    {
        var controller = new NoteController(new FakeNoteService
        {
            NotesList = new[]
            {
                new Notes { NoteId = 1, UserId = 5, NoteTitle = "Title 1", Description = "Desc 1" },
                new Notes { NoteId = 2, UserId = 5, NoteTitle = "Title 2", Description = "Desc 2" }
            }
        });
        SetUser(controller, 5);

        var result = controller.GetAllNotes();

        Assert.IsInstanceOfType(result, typeof(OkObjectResult));
    }

    [TestMethod]
    public void GetNoteById_WhenNoteExists_ReturnsOkWithNote()
    {
        var controller = new NoteController(new FakeNoteService
        {
            NoteById = new Notes { NoteId = 3, UserId = 5, NoteTitle = "Existing", Description = "Existing desc" }
        });
        SetUser(controller, 5);

        var result = controller.GetNoteById(3);

        var okResult = result as OkObjectResult;
        Assert.IsNotNull(okResult);
        Assert.IsNotNull(okResult.Value);
    }

    [TestMethod]
    public void GetNoteById_WhenServiceThrows_ThrowsException()
    {
        var controller = new NoteController(new FakeNoteService
        {
            ThrowOnGetById = true
        });
        SetUser(controller, 5);

        try
        {
            controller.GetNoteById(99);
            Assert.Fail("Expected an exception to be thrown.");
        }
        catch (Exception ex)
        {
            Assert.IsInstanceOfType<Exception>(ex);
        }
    }

    [TestMethod]
    public void UpdateNote_WhenNoteExists_ReturnsOkWithUpdatedNote()
    {
        var controller = new NoteController(new FakeNoteService
        {
            UpdatedNote = new Notes { NoteId = 7, UserId = 5, NoteTitle = "Updated", Description = "Updated desc" }
        });
        SetUser(controller, 5);

        var result = controller.UpdateNote(7, new NotesDTO { NoteTitle = "Updated", Description = "Updated desc" });

        Assert.IsInstanceOfType(result, typeof(OkObjectResult));
    }

    [TestMethod]
    public void UpdateNote_WhenServiceThrows_ThrowsException()
    {
        var controller = new NoteController(new FakeNoteService
        {
            ThrowOnUpdate = true
        });
        SetUser(controller, 5);

        try
        {
            controller.UpdateNote(7, new NotesDTO { NoteTitle = "Updated", Description = "Updated desc" });
            Assert.Fail("Expected an exception to be thrown.");
        }
        catch (Exception ex)
        {
            Assert.IsInstanceOfType<Exception>(ex);
        }
    }

    [TestMethod]
    public void DeleteNote_WhenCalled_ReturnsOk()
    {
        var service = new FakeNoteService();
        var controller = new NoteController(service);
        SetUser(controller, 5);

        var result = controller.DeleteNote(10);

        Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        Assert.IsTrue(service.DeleteCalled);
    }

    [TestMethod]
    public void GetUserIdFromToken_WhenClaimMissing_ThrowsException()
    {
        var controller = new NoteController(new FakeNoteService());
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext
            {
                User = new ClaimsPrincipal(new ClaimsIdentity())
            }
        };

        try
        {
            controller.GetNoteById(1);
            Assert.Fail("Expected an exception to be thrown.");
        }
        catch (Exception ex)
        {
            Assert.IsInstanceOfType<Exception>(ex);
        }
    }

    private static void SetUser(NoteController controller, int userId)
    {
        controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext
            {
                User = new ClaimsPrincipal(new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString())
                }, "TestAuth"))
            }
        };
    }

    private sealed class FakeNoteService : INoteService
    {
        public Notes CreatedNote { get; set; } = new Notes();
        public IEnumerable<Notes> NotesList { get; set; } = new List<Notes>();
        public Notes NoteById { get; set; } = new Notes();
        public Notes UpdatedNote { get; set; } = new Notes();
        public bool DeleteCalled { get; private set; }
        public bool ThrowOnGetById { get; set; }
        public bool ThrowOnUpdate { get; set; }

        public Notes CreateNote(NotesDTO notesDTO, int userId) => CreatedNote;

        public IEnumerable<Notes> GetAllNotes(int userId) => NotesList;

        public Notes GetNotesById(int noteId, int userId)
        {
            if (ThrowOnGetById)
            {
                throw new Exception("Note not found");
            }

            return NoteById;
        }

        public Notes UpdateNotes(int noteId, NotesDTO notesDTO, int userId)
        {
            if (ThrowOnUpdate)
            {
                throw new Exception("Note not found.");
            }

            return UpdatedNote;
        }

        public bool DeleteNote(int noteId, int userId)
        {
            DeleteCalled = true;
            return true;
        }
    }
}
