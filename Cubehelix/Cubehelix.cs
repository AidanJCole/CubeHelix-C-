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
        double hue = 1.4;
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
        public double StartLightness { get => startLightness; set => startLightness = value; }
        public double EndLightness { get => endLightness; set => endLightness = value; }

        public double getValue(double y)
        {
            return Math.Pow(interpolate(y, 0, 1, startLightness, endLightness), gamma);
        }

        private double findTheta(double y)
        {
            return 2*Math.PI*(start/3 + rotations*y);
        }

        private double findA( double y)
        {
            double yToTheGamma = Math.Pow(interpolate(y, 0, 1, startLightness, endLightness), gamma);
            return (hue * yToTheGamma * (1 - yToTheGamma)) / 2;
        }

        public Color getAtPoint(double y)
        {

            double theta = findTheta(y);
            double a = findA(y);
            double adjustedYToTheGamma = Math.Pow(interpolate(y, 0, 1, startLightness, endLightness), gamma);
            Matrix<double> lambdaAjdusted = DenseMatrix.OfArray(new double[,]
            {
                {adjustedYToTheGamma },
                {adjustedYToTheGamma },
                {adjustedYToTheGamma },
            });
            Matrix<double> angles = DenseMatrix.OfArray(new double[,]
            {
                { Math.Sin(theta) },
                {Math.Cos(theta) }

            });

            Matrix<double> result = lambdaAjdusted + a * magicNumbers * angles;

            //for(int i = 0; i<3;i++) result[i, 0] = Math.Sin(y * 2 * Math.PI+((i+1)%3) * 2 * Math.PI / 3)/2+.5;


            result *= 255;
            for (int i = 0; i < 3; i++)
            {
                if (result[i, 0] > 255)
                {
                    result[i, 0] = 255;
                }
                else if (result[i, 0] < 0)
                {
                    result[i, 0] = 0;
                }
                else if (double.IsNaN(result[i, 0]) || double.IsNegativeInfinity(result[i, 0]))
                {
                    result[i, 0] = 0;
                }
                else if (double.IsPositiveInfinity(result[i, 0]))
                {
                    result[i, 0] = 255;
                }
            }

            Color color = Color.FromArgb((int)result[0, 0], (int)result[1, 0], (int)result[2, 0]);
            return color;
        }

        public Matrix<double> getAPoint(double y)
        {

            double theta = findTheta(y);
            double a = findA(y);
            double adjustedYToTheGamma = Math.Pow(interpolate(y, 0, 1, startLightness, endLightness), gamma);
            Matrix<double> lambdaAjdusted = DenseMatrix.OfArray(new double[,]
            {
                {adjustedYToTheGamma },
                {adjustedYToTheGamma },
                {adjustedYToTheGamma },
            });
            Matrix<double> angles = DenseMatrix.OfArray(new double[,]
            {
                { Math.Sin(theta) },
                {Math.Cos(theta) }

            });

            Matrix<double> result = lambdaAjdusted + a * magicNumbers * angles;

            //for(int i = 0; i<3;i++) result[i, 0] = Math.Sin(y * 2 * Math.PI+((i+1)%3) * 2 * Math.PI / 3)/2+.5;

            return result;
        }

        private static double interpolate(double x, double x0, double x1, double y0, double y1)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }
    }
}
