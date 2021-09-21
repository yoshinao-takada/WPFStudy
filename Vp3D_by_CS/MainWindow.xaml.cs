using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vp3D_by_CS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMe_clicked(object sender, RoutedEventArgs e)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();
            Point3D[] meshPos = new Point3D[]
            {
                new Point3D(-0.3, -0.3, 0.3),
                new Point3D(0.3, -0.3, 0.3),
                new Point3D(0.3, 0.3, 0.3),
                new Point3D(-0.3, 0.3, 0.3)
            };
            mesh.Positions.Clear();
            mesh.Positions.Add(meshPos[0]);
            mesh.Positions.Add(meshPos[1]);
            mesh.Positions.Add(meshPos[2]);
            mesh.Positions.Add(meshPos[3]);
            mesh.TriangleIndices.Clear();
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3);
            mesh.Normals.Clear();
            mesh.TextureCoordinates.Clear();
            GeometryModel3D geometryModel3D = new GeometryModel3D();
            geometryModel3D.Geometry = mesh;
            Color brushColor = new Color()
            {
                A = 255,
                R = 0,
                G = 0,
                B = 0
            };
            geometryModel3D.Material = new DiffuseMaterial(new SolidColorBrush(brushColor));
            ModelVisual3D modelVisual3D = GeoModel;

            modelVisual3D.Content = geometryModel3D;

            GraphicsPort.Camera = new OrthographicCamera(
                new Point3D(0, 0, 2),
                new Vector3D(0, 0, -2),
                new Vector3D(0, 1, 0),
                3.0
                );

            MessageBox.Show("ClickMe_clicked() done", "message");
        }
    }
}
