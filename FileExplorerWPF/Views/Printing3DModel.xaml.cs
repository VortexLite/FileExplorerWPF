using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using Microsoft.Win32;
using HelixToolkit.Wpf;
using System.Windows.Media;
using System.IO;
using System.Reflection;
using System.Windows.Input;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Threading;

namespace FileExplorerWPF.Views
{
    /// <summary>
    /// Interaction logic for Printing3DModel.xaml
    /// </summary>
    public partial class Printing3DModel : Window
    {
        private ModelVisual3D model;
        private PerspectiveCamera camera;
        private Point previousMousePosition;

        private DispatcherTimer timer;
        private int progress;

        private string path;

        public Printing3DModel(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MaximizedButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Створення камери
            camera = new PerspectiveCamera
            {
                Position = new Point3D(0, 0, 5),
                LookDirection = new Vector3D(0, 0, -1),
                UpDirection = new Vector3D(0, 1, 0),
                FieldOfView = 45
            };

            // Створення світла
            var light = new DirectionalLight(Colors.White, new Vector3D(0, 0, -1));

            // Додавання камери і світла до сцени
            var modelGroup = new Model3DGroup();
            modelGroup.Children.Add(light);
            model = new ModelVisual3D { Content = modelGroup };
            viewport.Children.Add(model);

            LoadSTLModel(path);

            var copyPath = path.Substring(path.LastIndexOf("\\") + 1);
            NameModel.Text = copyPath;
        }

        private void LoadSTLModel(string filePath)
        {
            var reader = new StLReader();
            var model3D = reader.Read(filePath);

            // Очищення попередньої моделі
            var modelGroup = (Model3DGroup)model.Content;
            modelGroup.Children.Clear();

            // Додавання нової моделі
            modelGroup.Children.Add(model3D);

            // Позиціонування камери
            var bounds = model3D.Bounds;
            var diameter = Math.Max(bounds.SizeX, Math.Max(bounds.SizeY, bounds.SizeZ));
            camera.Position = new Point3D(bounds.X + diameter, bounds.Y + diameter, bounds.Z + diameter);
            camera.LookDirection = new Vector3D(-diameter, -diameter, -diameter);
        }

        private void Viewport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                previousMousePosition = e.GetPosition(viewport);
                viewport.CaptureMouse();
            }
        }

        private void Viewport_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var currentPosition = e.GetPosition(viewport);
                var delta = currentPosition - previousMousePosition;

                RotateCamera(delta.X, delta.Y);

                previousMousePosition = currentPosition;
            }
        }

        private void Viewport_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                viewport.ReleaseMouseCapture();
            }
        }

        private void RotateCamera(double deltaX, double deltaY)
        {
            const double rotationFactor = 0.3;
            var cameraDirection = camera.LookDirection;

            var rotationX = new AxisAngleRotation3D(new Vector3D(0, 1, 0), deltaY * rotationFactor);
            var rotationY = new AxisAngleRotation3D(new Vector3D(1, 0, 0), -deltaX * rotationFactor);

            var rotationTransform = new RotateTransform3D();
            rotationTransform.Rotation = new QuaternionRotation3D(new Quaternion(cameraDirection, 0));

            var transformGroup = new Transform3DGroup();
            transformGroup.Children.Add(rotationTransform);
            transformGroup.Children.Add(new RotateTransform3D(rotationX));
            transformGroup.Children.Add(new RotateTransform3D(rotationY));

            cameraDirection = transformGroup.Transform(cameraDirection);
            camera.UpDirection = transformGroup.Transform(camera.UpDirection);

            camera.LookDirection = cameraDirection;
        }

        private void Printing_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameModel.Text) &&
                !string.IsNullOrWhiteSpace(Printer.SelectedItem.ToString()) &&
                !string.IsNullOrWhiteSpace(CountModel.Text) &&
                !string.IsNullOrWhiteSpace(Scale.Text) &&
                !string.IsNullOrWhiteSpace(Materilal.Text))
            {
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(100);
                timer.Tick += Timer_Tick;

                progress = 0;
                ProgBar.Value = progress;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress++;
            ProgBar.Value = progress;

            if (progress >= 100)
            {
                MessageBox.Show("Друк закінчився", "Успіх", MessageBoxButton.OK);
                timer.Stop();
                ProgBar.Value = 0;
            }
        }
    }
}
