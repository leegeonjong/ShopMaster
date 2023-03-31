namespace ShopMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("header");
            {
                Console.WriteLine("헤더입니다"); // A#2
                Console.WriteLine("회원가입");   // b#4
            }
            Console.WriteLine("article");
            {
                Console.WriteLine("본문입니다");//A#3
            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("그레이엄 포터");//A#4
            }
        }

    }
}