using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wc.core.Contracts;

namespace wc.core.Services
{
    public class ArgumentsValidator : IArgumentsValidator
    {
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
