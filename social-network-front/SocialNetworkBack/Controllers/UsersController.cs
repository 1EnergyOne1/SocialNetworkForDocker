using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SocialNetworkBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [Route("GetUser")]
        [HttpGet]
        public async Task<ActionResult<User?>> GetUser([FromQuery] string login, [FromQuery] string password, CancellationToken ct)
        {
            User? user = await GetUserFromDatabaseAsync(login, password); // Пример асинхронного вызова

            if (user == null)
            {
                return NotFound(); // Возвращаем 404, если пользователь не найден
            }

            return Ok(user); // Возвращаем 200 и пользователя
        }

        private Task<User?> GetUserFromDatabaseAsync(string login, string password)
        {
            // Здесь должна быть логика получения пользователя
            // Для примера вернем нового пользователя
            return Task.FromResult<User?>(new User { Login = login, Name = "John Doe", Password = password, Id = 3, Age = 29, Datecreate = DateTime.Now, Isadmin = true, Lastname = "One" });
        }

        //[Route("GetAllUsers")]
        //[HttpGet]
        //public async Task<IEnumerable<User>?> GetAllUsers(CancellationToken ct)
        //{
        //    return await users.GetAllUsers(ct);
        //}

        //[Route("AddUser")]
        //[HttpPost]
        //public async Task<ActionResult<User?>> AddUser([FromBody] User user, CancellationToken ct)
        //{
        //    return await users.AddUser(user, ct);
        //}

        //[Route("UpdateUser")]
        //[HttpPut]
        //public async Task<ActionResult<User>> UpdateUser([FromBody] User user, CancellationToken ct)
        //{
        //    return await users.UpdateUser(user, ct);
        //}

        //[Route("DeleteUser")]
        //[HttpDelete]
        //public async Task<ActionResult<bool?>> DeleteUser([FromQuery] int id, CancellationToken ct)
        //{
        //    return await users.DeleteUser(id, ct);
        //}

        //[Route("AdAdmin")]
        //[HttpPost]
        //public async Task<ActionResult<User?>> AddAdmin([FromBody] User user, CancellationToken ct)
        //{
        //    return await users.AddAdmin(user, ct);
        //}
    }
}
