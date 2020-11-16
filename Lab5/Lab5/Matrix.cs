using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Matrix
    {
        public int[,] _matrix { get; }
        public int c { get; }
        public int l { get; }

        public Matrix(int sizeRow, int sizeCol, int[,] val)
        {
            _matrix = new int[sizeRow, sizeCol];
            for (int i = 0; i < sizeRow; i++)
            {
                if (val.GetLength(0) > i)
                {
                    for (int j = 0; j < sizeCol; j++)
                    {
                        if (val.GetLength(1) > j)
                        {
                            _matrix[i, j] = val[i, j];
                        }
                        else
                        {
                            _matrix[i, j] = 0;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < sizeCol; j++)
                    {
                        _matrix[i, j] = 0;
                    }
                }
            }
            l = sizeRow;
            c = sizeCol;
        }

        public void AddElem(int row, int col, int value)
        {
            if (row <= l)
            {
                if (col <= c)
                    _matrix[row, col] = value;
            }
        }

        public int[,] AddMatrix(int[,] matrixA)
        {
            int[,] matrixResult;
            if (matrixA.GetLength(0) > _matrix.GetLength(0))
            {
                matrixResult = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
                matrixResult = matrixA;

                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1); j++)
                    {
                        matrixResult[i, j] = matrixA[i, j] + _matrix[i, j];
                    }
                }
            }
            else
            {
                matrixResult = new int[_matrix.GetLength(0), _matrix.GetLength(1)];
                matrixResult = _matrix;

                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {
                        matrixResult[i, j] = matrixA[i, j] + _matrix[i, j];
                    }
                }
            }
            return matrixResult;
        }
    }

    class MatrixIrregular
    {
        protected int[][] _matrix;
        protected int c;
        protected int l;
        public MatrixIrregular(int sizeRow, int sizeCol, int[][] val)
        {
            _matrix = new int[sizeRow][];
            for (int i = 0; i < sizeRow; i++)
            {
                _matrix[i] = new int[sizeCol];
                if (val.GetLength(0) > i)
                {
                    for (int j = 0; j < sizeCol; j++)
                    {
                        if (val[i].GetLength(0) > j)
                        {
                            _matrix[i][j] = val[i][j];
                        }
                        else
                        {
                            _matrix[i][j] = 0;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < sizeCol; j++)
                    {
                        _matrix[i][j] = 0;
                    }
                }
            }
            l = sizeRow;
            c = sizeCol;
        }
        public void calculateColsAdd(int[][] matrixA, int[][] matrixResult, int i)
        {
            if (matrixA[i].GetLength(0) > _matrix[i].GetLength(0))
            {
                matrixResult[i] = new int[matrixA[i].GetLength(0)];
                matrixResult[i] = matrixA[i];
                for (int j = 0; j < _matrix[i].GetLength(0); j++)
                {
                    matrixResult[i][j] = matrixA[i][j] + _matrix[i][j];
                }
            }
            else
            {
                matrixResult[i] = new int[_matrix[i].GetLength(0)];
                matrixResult[i] = _matrix[i];
                for (int j = 0; j < matrixA[i].GetLength(0); j++)
                {
                    matrixResult[i][j] = matrixA[i][j] + _matrix[i][j];
                }
            }
        }
        public int[][] AddMatrix(int[][] matrixA)
        {
            int[][] matrixResult;
            if (matrixA.GetLength(0) > _matrix.GetLength(0))
            {
                matrixResult = new int[matrixA.GetLength(0)][];

                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    calculateColsAdd(matrixA, matrixResult, i);
                }
                for (int i = _matrix.GetLength(0); i < matrixA.GetLength(0); i++)
                {
                    matrixResult[i] = new int[matrixA[i].GetLength(0)];
                    matrixResult[i] = matrixA[i];
                }
            }
            else
            {
                matrixResult = new int[_matrix.GetLength(0)][];

                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    calculateColsAdd(matrixA, matrixResult, i);
                }
                for (int i = matrixA.GetLength(0); i < _matrix.GetLength(0); i++)
                {
                    matrixResult[i] = new int[_matrix[i].GetLength(0)];
                    matrixResult[i] = _matrix[i];
                }
            }
            return matrixResult;
        }

        public void calculateColsOdd(int[][] matrixA, int[][] matrixResult, int i)
        {
            if (matrixA[i].GetLength(0) > _matrix[i].GetLength(0))
            {
                matrixResult[i] = new int[matrixA[i].GetLength(0)];
                matrixResult[i] = matrixA[i];
                for (int j = 0; j < _matrix[i].GetLength(0); j++)
                {
                    matrixResult[i][j] = matrixA[i][j] - _matrix[i][j];
                }
            }
            else
            {
                matrixResult[i] = new int[_matrix[i].GetLength(0)];
                matrixResult[i] = _matrix[i];
                for (int j = 0; j < matrixA[i].GetLength(0); j++)
                {
                    matrixResult[i][j] = matrixA[i][j] - _matrix[i][j];
                }
            }
        }

        public int[][] OddMatrix(int[][] matrixA)
        {
            int[][] matrixResult;
            if (matrixA.GetLength(0) > _matrix.GetLength(0))
            {
                matrixResult = new int[matrixA.GetLength(0)][];

                for (int i = 0; i < _matrix.GetLength(0); i++)
                {
                    calculateColsOdd(matrixA, matrixResult, i);
                }
                for (int i = _matrix.GetLength(0); i < matrixA.GetLength(0); i++)
                {
                    matrixResult[i] = new int[matrixA[i].GetLength(0)];
                    matrixResult[i] = matrixA[i];
                }
            }
            else
            {
                matrixResult = new int[_matrix.GetLength(0)][];

                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    calculateColsOdd(matrixA, matrixResult, i);
                }
                for (int i = matrixA.GetLength(0); i < _matrix.GetLength(0); i++)
                {
                    matrixResult[i] = new int[_matrix[i].GetLength(0)];
                    matrixResult[i] = _matrix[i];
                }
            }
            return matrixResult;
        }

        public void Print(int[][] value)
        {
            foreach (var elem in value)
            {
                foreach (var el in elem)
                    Console.Write(el + ", ");
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }

    }
}
