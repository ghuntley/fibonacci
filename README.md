![](http://i.imgur.com/U1xuDOk.png)
# Fibonacci [![Build status](https://ci.appveyor.com/api/projects/status/jv08td6erbve1239?svg=true)](https://ci.appveyor.com/project/ghuntley/fibonacci)


Fibonacci is a sequence generator that is performant from Int32 all the way up to BigInteger. The current implementation
of ```Fibonaci.Nth``` uses the [Fast Doubling](http://www.m-hikari.com/imf-password2008/1-4-2008/ulutasIMF1-4-2008.pdf) algorithm.  

There are faster and slower implementations available, feel free to send pull requests through as you see fit. If the
algorithm you are submitting is faster than the current one then please change ```Fibonaci.Nth``` to use it.

# Supported Platforms

* .NET 4.5 (We are a Profile78 Portable Class Library)
* Mono
* Xamarin.iOS
* Xamarin.Android
* Xamarin.Mac

# Installation
Installation is done via NuGet:

	Install-Package Fibonnaci

# Usage

	using Fibonnaci;

    long fib = Fibonaci.Nth(91);                       // 4660046610375530309   
    long fib = Fibonaci.Nth(92);                       // ArgumentOutOfRangeException as fib would exceed Int64.MaxValue 
    BigInteger fib = Fibonaci.Nth(new BigInteger(92))  // 7540113804746346429
    BigInteger fib = Fibonaci.Nth(new BigInteger(100)) // BigInteger.Parse("354224848179261915075")
    BigInteger fib = Fibonaci.Nth(new BigInteger(1000) // BigInteger.Parse("43466557686937456435688527675040625802564660517371780402481729089536555417949051890403879840079255169295922593080322634775209689623239873322471161642996440906533187938298969649928516003704476137795166849228875"));


# Recommended Reading
* https://bosker.wordpress.com/2011/04/29/the-worst-algorithm-in-the-world/

* https://bosker.wordpress.com/2011/07/27/computing-fibonacci-numbers-using-binet%E2%80%99s-formula/

* https://news.ycombinator.com/item?id=2537811

* http://www.ics.uci.edu/~eppstein/161/960109.html

* http://www.ii.uni.wroc.pl/~lorys/IPL/article75-6-1.pdf

* https://weblogs.java.net/blog/kabutz/archive/2012/02/24/fibonacci-1000000000-challenge

## With thanks to
* The icon "<a href="http://thenounproject.com/term/fibonacci-circles/43316/" target="_blank">Fibonacci Circles</a>" designed by <a href="http://thenounproject.com/jaevernonaquino/" target="_blank">Jae Aquino</a> from The Noun Project.
