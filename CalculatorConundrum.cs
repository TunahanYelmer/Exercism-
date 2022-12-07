using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        switch (operation)
        {
            case "+":
                return $"{operand1} {operation} {operand2} = {(operand1 + operand2).ToString()}";
            case "-":
                return $"{operand1} {operation} {operand2} = {(operand1 - operand2).ToString()}";
            case "*":
                return $"{operand1} {operation} {operand2} = {(operand1 * operand2).ToString()}";
            case "/":
                if (operand2 == 0)
                {
                    return "Division by zero is not allowed.";
                }
                else
                {
                    return $"{operand1} {operation} {operand2} = {(operand1 / operand2).ToString()}";
                }
            case null:
                throw new ArgumentNullException();
            case "":
                throw new ArgumentException();        
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
