using JWTAuthExample.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthExample.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IJwtAuthenticate _jwtAuthenticate;

        private readonly List<Member> _members = new()
        {
            new Member{ Id = 1, Name="David" },
            new Member{ Id = 2, Name="Quinton" },
            new Member{ Id = 3, Name="Alex" },
            new Member{ Id = 4, Name="Ryan" },
            new Member{ Id = 5, Name="Steve" },
        };

        public MembersController(IJwtAuthenticate jwtAuthenticate)
        {
            _jwtAuthenticate = jwtAuthenticate;
        }

        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<Member> AllMembers()
        {
            return _members;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public Member? MemberById(int id)
        {
            var member = _members.Find(member => member.Id == id);
            return member;
        }

        [AllowAnonymous]
        // POST api/<MembersController>
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody] UserCredential userCredential)
        {
            var request = new JwtAuthenticateRequest
            {
                Username = userCredential.UserName,
                Password = userCredential.Password
            };

            var token = _jwtAuthenticate.Authentication(request);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
