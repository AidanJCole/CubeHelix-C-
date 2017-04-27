using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Drawing;


namespace Cubehelix
{
    class Cubehelix
    {
        double rotations = 1.5;
        double gamma = 1.0;
        double start = .5;
        double hue = 2;
        double startLightness = 0;
        double endLightness = 1;

        public Cubehelix()
        {

        }

        Matrix<double> magicNumbers = DenseMatrix.OfArray(new double[,]
        {
            {-.14861, 1.78277 },
            {-.29227, -.90649 },
            {1.97294, 0 }
        });

        public double Rotations { get => rotations; set => rotations = value; }
        public double Gamma { get => gamma; set => gamma = value; }
        public double Start { get => start; set => start = value; }
        public double Hue { get => hue; set => hue = value; }

        private double findTheta(double y)
        {
            return 2*Math.PI*(start/3 + rotations*y);
        }

        private double findA( double y)
        {
            
            double yToTheGamma = Math.Pow(y, gamma);
            return (hue * yToTheGamma * (1 - yToTheGamma)) / 2;
        }

        public Color getAtPoint(double y)
        {
            
            double theta = findTheta(y);
            double yToTheGamma = Math.Pow(y, gamma);
            double a = findA(y);
            Matrix<double> lambdaAjdusted = DenseMatrix.OfArray(new double[,]
            {
                {yToTheGamma },
                {yToTheGamma },
                {yToTheGamma },
            });
            Matrix<double> angles = DenseMatrix.OfArray(new double[,]
            {
                { Math.Sin(theta) },
                {Math.Cos(theta) }
                
            });

            Matrix<double> result = lambdaAjdusted + a * magicNumbers * angles;
            result *= 255;
            for (int i = 0; i < 3; i++)
            {
                if(result[i,0] > 255)
                {
                    result[i,0] = 255;
                }
                else if (result[i,0] < 0)
                {
                    result[i,0] = 0;
                }
                else if (double.IsNaN(result[i, 0]))
                {
                    result[i, 0] = 0;
                }
            }
            Color color = Color.FromArgb((int)result[0, 0], (int)result[1,0], (int)result[2,0]);
            return color;
        }
    }
}
