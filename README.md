# BlazorWA-1K-Slowness-Test
Fast-Raw-Test to reproduce a Blazor Webassembly slowness while rendering 1k records

I was curious about a Twitter user claims 

```
``Blazor Webassembly is not ready for prime time´´
```

And, as a Blazor fan, I ran to verify it... and he was right... kind of.


For one side, he was right because if you plan to generate 1k+ records with 30 properties each, and fill 12 of those properties (per item) with a JSON serialization result, then definetively you'll be putting Blazor on its knees.

But for the other side, you don't want to do that, especially in the way this test is implemented, there are way better options to do it.

So I'm letting this here for the posterity, to show others how no to do it ;)

BTW, here's the [twit](https://twitter.com/henalbrod/status/1285692053142241285)

