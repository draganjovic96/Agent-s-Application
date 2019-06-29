using AgentApplication.AccommodationUnitService;
using AgentApplication.Model;
using AgentApplication.ViewModel;
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

namespace AgentApplication.View
{
    /// <summary>
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : UserControl
    {
        public Units(User loggedUser)
        {
            InitializeComponent();
			DataContext = new UnitsViewModel(loggedUser);
			//UnitsTable.ItemsSource = unitsResponse.accommodationUnits;
        }
    }
}
