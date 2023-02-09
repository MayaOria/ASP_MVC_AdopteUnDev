using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projet_ASP.Handlers
{
    public class SessionManager
    {
        private readonly ISession _session;

        public SessionManager(IHttpContextAccessor accessor)
        {
            _session = accessor.HttpContext.Session;
        }

        public CurrentUser currentUser
        {
            get
            {
                string data = _session.GetString(nameof(currentUser));
                if(data is null) return null;
                return JsonSerializer.Deserialize<CurrentUser>(data);
            }

            set
            {
                if (value is null) _session.Remove(nameof(CurrentUser));
                else _session.SetString(nameof(CurrentUser), JsonSerializer.Serialize(value));
            }

        }
    }
}
