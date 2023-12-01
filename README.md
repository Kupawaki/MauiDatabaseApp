# MauiDatabaseApp

So, as a final assignment for this independent study, I am supposed to do a writeup of my experience with .NET Maui, which I am happy to do because I have a lot to say.
Without further ado, I present:

## .NET Maui: The Good, The Bad, and The Terrible

So, yeah, maybe you can tell by the title, but Maui isn't all that great. As I improve as a developer,
I tend to understand better and better what makes or breaks a development environment. Maui walks that tightrope for me.
My opinion on Maui is usually more negative than positive, but before we get into that droll, let's begin with what I actually like.

### - The Good

**Maui is a child of .NET**

So, because Maui is a part of .NET, it benefits from all the great things all the other .NET packages do, namely, a really good community.
I would say that one of the best things about Maui is its access to NuGet packages, created by the .NET community, which makes my job much easier.
It's other main community benefit is communal coding. By that, I mean that any error I had during this time was not new to the community; it had been documented and usually solved.
Someone on stack overflow had my error, and someone else had solved it. This is something that does not happen with more obscure stuff, like Clojure, for example.

**Maui uses XAML for UI**

XAML is my favorite language to develop user interfaces; its structure and tag system just make sense to me. XAML is like if HTML wasn't such a nightmare.

**C#**

I guess this is true with all .NET stuff, but Maui is written in C#, which is a language that gets a lot of hate in my group of peers and professors, but I like it.
"It's just Microsoft Java," they cry, to which I reply,
"Have fun manually writing a runnable that contains a thread instead of using the await keyword and then waiting 11 years for the JRE to finally finish its job."

### - The Bad

**The Docs**

Yeah, the docs aren't so great. There are lots and lots of outdated code snippets, or sometimes just blatantly wrong information.
This really revealed itself during my midterm when I was doing Reversi and trying to get the children of an element. Not so fun.
Thank God for Stack Overflow and the wizards who answer questions.

**Object Oriented?**

Another thing that came up during my midterm was .NET Maui's attempt to force you to use bindings for everything you want to do.
Bindings are usually pretty great, but they get complicated really quickly, and honestly, they aren't something I fully understand.
C# is object-oriented, and XAML is written in an heirarchical structure.
So I shouldn't have to use a 3rd-level ancestry type binding tied to a Model View View-Model structure via an ICommand,
just to get a reference to the child of an XAML element.
Which is what the docs recommend, by the way.

And if you are wondering, don't do that. Use the ElementAt method.

**No Real Theming**

I really expected Maui to have more of a theme thing going on, but I was very disappointed.
It has even fewer default theme features than a WPF app, which is also .NET.
My week on themes really just made me miss Android's Material Design implementation.

### - The Terrible

I only have one thing to say for this category: There is a reason cross-platform development is not an industry standard.
No one has managed to pull it off in a way that makes sense, and that includes Maui.
Most of the time, I was left feeling that I would have absolutely been better off programming on four separate platforms.
rather than trying to fix whatever obscure error or missing feature I was dealing with.
This entire thing could be summed up as ".NET Maui is missing very important platform-specific features."
You might say, "No, you can access every feature of a platform if you do a bunch of nonsense and write platform-specific code!"
But if we have to do that, then why are we using Cross-Platform at all?

#### Lessons Learned

1. ChatGPT is so, so good at navigating documentation and providing code snippets that actually work.
2. There is a reason cross-platform isn't the standard. It is hard to do, right?
3. Mac does not play nice with Visual Studio and is actually being retired this August.
4. I should really take more of Dr. Hoot's advice.
5. Auto-generated code is handy, but it should not be your first exposure to a concept.
6. I think MVVM is overused. Not every app needs a view model.
7. IDEs with Git integration are great.
