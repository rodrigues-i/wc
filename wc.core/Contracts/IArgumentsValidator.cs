using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wc.core.Contracts
{
    public interface IArgumentsValidator
    {
        bool FileExists(string filePath);
    }
}
