using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Project.Models
{
    public interface IObjectFactory
    {
        T Create<T>(params object[] args) where T : class;
    }
}
