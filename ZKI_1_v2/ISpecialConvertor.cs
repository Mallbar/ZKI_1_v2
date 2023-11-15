    interface ISpecialConvertor
    {
       static public string MatrixToString(char[,] matrix) 
       {
            string text = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    text += matrix[i, j];
                }
            }
            return text;
       }
       static public void StringToMatrix(char[,] matrix, string text)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = text[i * matrix.GetLength(1)  + j];
                }
            }
        }
        
    }
    
