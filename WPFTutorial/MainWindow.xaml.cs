using System.Windows;
using WPFTutorial.ViewModel;

namespace WPFTutorial
{

    //public partial class MainWindow : Window, INotifyPropertyChanged
    public partial class MainWindow : Window
    {

        //bool running = false;
        public MainWindow()
        {
            //DataContext = this;

            //entires = new ObservableCollection<string>();

            InitializeComponent();
            MainWindowViewModel viewModel = new();
            DataContext = viewModel;
        }

        //private void btnNormal_Click(object sender, RoutedEventArgs e)
        //{
        //    NormalWindow normalWindow = new NormalWindow();
        //    normalWindow.Show();
        //}

        //private void btnModal_Click(object sender, RoutedEventArgs e)
        //{
        //    ModalWindow modalWindow = new ModalWindow(this);
        //    Opacity = 0.4;
        //    modalWindow.ShowDialog();
        //    Opacity = 1.0;
        //    if (modalWindow.Success)
        //    {
        //        txtInput.Text = modalWindow.Input;
        //    }
        //}

        //private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //private void btnMinimize_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void btnMiximize_Click(object sender, RoutedEventArgs e)
        //{
        //    if (WindowState == WindowState.Maximized)
        //    {
        //        WindowState = WindowState.Normal;
        //    }
        //    else
        //    {
        //        WindowState = WindowState.Maximized;
        //    }
        //}

        //private void btnClose_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //    //Application.Current.Shutdown();
        //}

        //private void btnDetails_Click(object sender, RoutedEventArgs e)
        //{
        //    expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
        //}

        //private ObservableCollection<string> entires;

        //public ObservableCollection<string> Entires
        //{
        //    get { return entires; }
        //    set { entires = value; }
        //}


        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    //lvEntries.Items.Add(txtEntry.Text);
        //    Entires.Add(txtEntry.Text);
        //}

        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    //int index = lvEntries.SelectedIndex;

        //    //if (index == -1)
        //    //{
        //    //    return;
        //    //}

        //    //lvEntries.Items.RemoveAt(index);
        //    ///
        //    //object item = lvEntries.SelectedItem;
        //    //if (item == null)
        //    //{
        //    //    return;
        //    //}

        //    //MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete: {(string)item}?", "Sure?", MessageBoxButton.YesNo);
        //    //if (result == MessageBoxResult.Yes) { lvEntries.Items.Remove(item); }

        //    //var items = lvEntries.SelectedItems;
        //    //MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete: {items.Count}?", "Sure?", MessageBoxButton.YesNo);
        //    //if (result == MessageBoxResult.Yes)
        //    //{
        //    //    var itemsList = new ArrayList(items);
        //    //    foreach (var item in itemsList)
        //    //    {
        //    //        lvEntries.Items.Remove(item);
        //    //    }
        //    //}

        //    string selectedItem = (string)lvEntries.SelectedItem;
        //    Entires.Remove(selectedItem);


        //}

        //private void btnClear_Click(object sender, RoutedEventArgs e)
        //{
        //    //lvEntries.Items.Clear();
        //    Entires.Clear();
        //}

        //private void btnFire_Click(object sender, RoutedEventArgs e)
        //{

        //    OpenFolderDialog dialog = new OpenFolderDialog();
        //    dialog.InitialDirectory = "C:\\Users\\osama\\WindowsProjects\\WPFTutorial";
        //    bool? success = dialog.ShowDialog();
        //    if (success == true)
        //    {
        //        string path = dialog.FolderName;
        //        string filename = dialog.SafeFolderName;
        //        //tbInfo.Text = filename;
        //    }

        //}

        //private void btnFire_Click(object sender, RoutedEventArgs e)
        //{
        // MessageBox.Show("Could not open file.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
        //MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

        //if (result == MessageBoxResult.Yes)
        //{
        //    tbInfo.Text = "Agreed";
        //}
        //else
        //{
        //    tbInfo.Text = "Not Agreed";
        //}
        //}

        //private void btnFire_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog fileDialog = new OpenFileDialog();
        //    fileDialog.Filter = "C# Source Files | *.cs";
        //    //fileDialog.InitialDirectory = "C:\\temp";
        //    fileDialog.Title = "Please pick a CS Source file(s)...";
        //    fileDialog.Multiselect = true;

        //    bool? success = fileDialog.ShowDialog();
        //    if (success == true)
        //    {
        //        //string path = fileDialog.FileName;
        //        //string filename = fileDialog.SafeFileName;
        //        //tbInfo.Text = filename;

        //        string[] paths = fileDialog.FileNames;
        //        string[] filenames = fileDialog.SafeFileNames;
        //    }
        //    else
        //    {
        //        // Didn't pick anything
        //    }
        //}

        //private string? boundText;

        //public event PropertyChangedEventHandler? PropertyChanged;

        //public string? BoundText
        //{
        //    get { return boundText; }
        //    set
        //    {
        //        boundText = value;
        //        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
        //        //OnPropertyChanged(nameof(BoundText));
        //        OnPropertyChanged();

        //    }
        //}

        //private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //private void btnSet_Click(object sender, RoutedEventArgs e)
        //{

        //    BoundText = "set form code";

        //}


        //private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        //{
        //    if (running) {
        //        tbStatus.Text = "Stopped";
        //        btnToggleRun.Content = "Run";
        //    }
        //    else
        //    {
        //        tbStatus.Text = "Running";
        //        btnToggleRun.Content = "Stop";
        //    }

        //    running = !running;
        //}
    }
}