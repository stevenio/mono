// CS1620: Argument `1' must be passed with the `ref' keyword
// Line: 24

public class X
{
	public void Foo (string[] b)
	{
	}
	
	public void Foo (ref string i)
	{
	}
	
	public void Foo (int i)
	{
	}
}

class D
{
	static void Main ()
	{
		X x = null;
		x.Foo ("hola");
	}
}

