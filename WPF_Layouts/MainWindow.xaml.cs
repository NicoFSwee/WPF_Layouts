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

namespace WPF_Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnDock.Click += BtnDock_Click;
            btnStackPanel.Click += BtnStackPanel_Click;
            btnGrid.Click += BtnGrid_Click;
            btnGridSplitter.Click += BtnGridSplitter_Click;
        }

        private void BtnGridSplitter_Click(object sender, RoutedEventArgs e)
        {
            GridSplitterWindow gridSplitterWindow = new GridSplitterWindow();
            this.Hide();
            gridSplitterWindow.Show();
            gridSplitterWindow.Closed += GridSplitterWindow_Closed;
        }

        private void GridSplitterWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            this.Hide();
            gridWindow.Show();
            gridWindow.Closed += GridWindow_Closed;
        }

        private void GridWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            this.Hide();
            stackPanelWindow.Show();
            stackPanelWindow.Closed += StackPanelWindow_Closed;
        }

        private void StackPanelWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BtnDock_Click(object sender, RoutedEventArgs e)
        {
            DockWindow dockWindow = new DockWindow();
            this.Hide();
            dockWindow.Show();
            dockWindow.Closed += DockWindow_Closed;
        }

        private void DockWindow_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
