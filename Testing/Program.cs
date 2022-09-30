using NumericSystem;
using NumericSystem.Base;
namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- From BINARY ----");
            Base num = new BinarySystem("1010");
            var binary = num.To(NumericKinds.BINARY);
            var octal = num.To(NumericKinds.OCTAL);
            var dec = num.To(NumericKinds.DECIMAL);
            var hexadecimal = num.To(NumericKinds.HEXADECIMAL);


            Console.WriteLine($"({num.Value})({ NumericKinds.BINARY}) = ({binary}){ NumericKinds.BINARY}");
            Console.WriteLine($"({num.Value})({ NumericKinds.BINARY}) = ({octal}){ NumericKinds.OCTAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.BINARY}) = ({dec}){ NumericKinds.DECIMAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.BINARY}) = ({hexadecimal}){ NumericKinds.HEXADECIMAL}");

            Console.WriteLine("---- From OCTAL ----");

            num = new OctalSystem("12");
            binary = num.To(NumericKinds.BINARY);
            octal = num.To(NumericKinds.OCTAL);
            dec = num.To(NumericKinds.DECIMAL);
            hexadecimal = num.To(NumericKinds.HEXADECIMAL);

            Console.WriteLine($"({num.Value})({ NumericKinds.OCTAL}) = ({binary}){ NumericKinds.BINARY}");
            Console.WriteLine($"({num.Value})({ NumericKinds.OCTAL}) = ({octal}){ NumericKinds.OCTAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.OCTAL}) = ({dec}){ NumericKinds.DECIMAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.OCTAL}) = ({hexadecimal}){ NumericKinds.HEXADECIMAL}");

            Console.WriteLine("---- From DECIMAL ----");

            num = new DecimalSystem("10");
            binary = num.To(NumericKinds.BINARY);
            octal = num.To(NumericKinds.OCTAL);
            dec = num.To(NumericKinds.DECIMAL);
            hexadecimal = num.To(NumericKinds.HEXADECIMAL);


            Console.WriteLine($"({num.Value})({ NumericKinds.DECIMAL}) = ({binary}){ NumericKinds.BINARY}");
            Console.WriteLine($"({num.Value})({ NumericKinds.DECIMAL}) = ({octal}){ NumericKinds.OCTAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.DECIMAL}) = ({dec}){ NumericKinds.DECIMAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.DECIMAL}) = ({hexadecimal}){ NumericKinds.HEXADECIMAL}");

            Console.WriteLine("---- From HEXADECIMAL ----");


            num = new HexaDecimalSystem("A");
            binary = num.To(NumericKinds.BINARY);
            octal = num.To(NumericKinds.OCTAL);
            dec = num.To(NumericKinds.DECIMAL);
            hexadecimal = num.To(NumericKinds.HEXADECIMAL);

            Console.WriteLine($"({num.Value})({NumericKinds.HEXADECIMAL}) = ({binary}){NumericKinds.BINARY}");
            Console.WriteLine($"({num.Value})({NumericKinds.HEXADECIMAL}) = ({octal}){NumericKinds.OCTAL}");
            Console.WriteLine($"({num.Value})({NumericKinds.HEXADECIMAL}) = ({dec}){NumericKinds.DECIMAL}");
            Console.WriteLine($"({num.Value})({NumericKinds.HEXADECIMAL}) = ({hexadecimal}){NumericKinds.HEXADECIMAL}");

            binary = num.ToBinary();
            octal = num.ToOctal();
            dec = num.ToDecimal();
            hexadecimal = num.ToHexaDecimal();

            Console.WriteLine($"({num.Value})({ NumericKinds.HEXADECIMAL}) = ({binary}){ NumericKinds.BINARY}");
            Console.WriteLine($"({num.Value})({ NumericKinds.HEXADECIMAL}) = ({octal}){ NumericKinds.OCTAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.HEXADECIMAL}) = ({dec}){ NumericKinds.DECIMAL}");
            Console.WriteLine($"({num.Value})({ NumericKinds.HEXADECIMAL}) = ({hexadecimal}){ NumericKinds.HEXADECIMAL}");
            Console.ReadKey();
        }
    }
}