using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    public class MessageResult
    {
        public List<string> ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public bool IsSucceed { get; set; }
    }
}
