using Application.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Core
{
    public class TextLogger : ILogger
    {
        public async Task Log(IAppActor actor, IUseCase useCase, object objInput)
        {
            var textUpis = $"{DateTime.Now}__||__{actor.Identity}__||__{useCase.Name_UseCase}__||__{useCase.Id_UseCase}__||__{JsonConvert.SerializeObject(objInput)}";

            var putanja = Path.Combine("wwwroot", "Logs", "logs.txt");
            using var fs = File.AppendText(putanja);
            fs.WriteLine(textUpis);
        }
    }
}
