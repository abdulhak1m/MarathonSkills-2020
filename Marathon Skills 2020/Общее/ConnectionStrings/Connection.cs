using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon_Skills_2020.Общее.ConnectionStrings
{
    public class Connection
    {
        public static string GetString()
        {
            return @"Data Source=DESKTOP-57F7258;Initial Catalog=MarathonSkills;Integrated Security=True";
        }
    }
}
