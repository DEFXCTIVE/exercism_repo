using System.Collections;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        switch (operation)
        {
            case null:
                throw new ArgumentNullException();
            case "":
                throw new ArgumentException();
            case "+":
                return $"{operand1} {operation} {operand2} = {operand1 + operand2}";
            case "-":
                return $"{operand1} {operation} {operand2} = {operand1 - operand2}";
            case "*":
                return $"{operand1} {operation} {operand2} = {operand1 * operand2}";
            case "/":
                if (operand1 == 0 || operand2 == 0)
                {
                   return "Division by zero is not allowed.";
                }
                return $"{operand1} {operation} {operand2} = {operand1 / operand2}";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
