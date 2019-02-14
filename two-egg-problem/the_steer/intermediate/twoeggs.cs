using System;
class X{
    static void Main(string[] args){
        uint N=uint.Parse(args[0]), b=uint.Parse(args[1]), s=1, e=2, z=N, t;
        do {
            t = e < 2 ? s : s + (uint)Math.Ceiling((N - s) / Math.Sqrt(N - s));
            Console.WriteLine(t);
            if (t >= b) {
                Console.WriteLine("True");
                if (--e == 0 || t == b) {
                    s = t;
                    break;
                }
                z = t - 1;
                t = s - 1;
            } else Console.WriteLine("False");
            s = t + 1;
        } while (s < z);
        Console.WriteLine("Floor: "+s);
    }
}