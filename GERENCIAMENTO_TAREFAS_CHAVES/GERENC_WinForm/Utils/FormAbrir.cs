using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WinForm.Utils
{
    public static class FormAbrir
    {
        public static T Create<T>() where T : Form
        {
            return Program.ServiceProvider.GetRequiredService<T>();
        }
    }
}
