using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldSkills
{
    /// <summary>
    /// Логика взаимодействия для AgentUC.xaml
    /// </summary>
    public partial class AgentUC : UserControl
    {
        public AgentUC(Agent agent)
        {
            InitializeComponent();

            TypeName.Text = agent.Type + " | " + agent.Name;
            Sales.Text = agent.Sales;
            PhoneNumber.Text = agent.PhoneNumber;
            Priority.Text = agent.Priority;
            Discount.Text = agent.Discount;
        }
    }
}
