using Dashboard.BD;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Dashboard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsMaximized = false;

        public MainWindow()
        {
            InitializeComponent();

            //var converter = new BrushConverter(); 
            //ObservableCollection<Member> members = new ObservableCollection<Member>();

            //members.Add(new Member { Number = "1", Chatacter = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "fdb", Position = "Coach", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "2", Chatacter = "G", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "xzcv", Position = "Administrator", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "3", Chatacter = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "sad", Position = "Coach", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "4", Chatacter = "S", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "xzc", Position = "Manager", Email = "fdgdf@gmail.com", Phone = "415-954-1415" });
            //members.Add(new Member { Number = "5", Chatacter = "A", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "bcvbz", Position = "Manager", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "6", Chatacter = "Q", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "asdsa ds", Position = "Coach", Email = "fdgdf@gmail.com", Phone = "415-954-1335" });
            //members.Add(new Member { Number = "7", Chatacter = "E", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "xzcxc x", Position = "Manager", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "8", Chatacter = "R", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "cxzc", Position = "Manager", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "9", Chatacter = "W", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "cx", Position = "Administrator", Email = "fdgdf@gmail.com", Phone = "415-954-1475" });
            //members.Add(new Member { Number = "10", Chatacter = "X", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "z", Position = "Coach", Email = "fdgdf@gmail.com", Phone = "415-954-2222" });

            //membersDataGrid.ItemsSource = members;

            DbConnectorHelper.entObj = new BDforPR41Entities();
            membersDataGrid.ItemsSource = DbConnectorHelper.entObj.members.ToList();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }

    }

    public class Member
    {
        public string Chatacter { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}