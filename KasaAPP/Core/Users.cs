using Application.Core;
using System.Collections.Generic;

namespace KasaAPP.Core
{
    public class AnonymusUser : IAppActor
    {
        public int Id => -1;

        public string Identity => "Anonymus user";

        public IEnumerable<int> AllowedActions => new List<int> { 19 };
    }

    public class JwtUser : IAppActor
    {
        public string Identity { get; set; }

        public int Id { get; set; }
        public IEnumerable<int> AllowedActions { get; set; } = new List<int>();

    }
}
