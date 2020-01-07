public class FooBar
{
    private int n;

    public FooBar(int n)
    {
        this.n = n;
    }

    bool flag = false;

    public void Foo(Action printFoo)
    {

        for (int i = 0; i < n; i++)
        {

            while (flag)
            {
                System.Threading.Thread.Sleep(1);
            }
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            flag = true;
        }
    }

    public void Bar(Action printBar)
    {

        for (int i = 0; i < n; i++)
        {

            while (!flag)
            {
                System.Threading.Thread.Sleep(1);
            }
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            flag = false;
        }
    }
}