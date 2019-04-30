[logo]: https://ispsession.io/images/Platipus3_Transparant_small.png "ISP Session for ASP.NET Core"

# DemoIspSessionCore
Demonstrates how to implement ISP Session for ASP.NET Core and ISP Cache
Created at April 27,2019.
Using Visual Studio 2017 and a default 'new ASP.NET Core MVC project' without modifying the code.  
Only ISP Session has been added and necessary code to demonstrate how it works.

ISP Session is a product that can be found at https://ispsession.io

It allows you to have compatible session state with ASP.Net Framework up to 4.8 (provided you use ISP Session there too).
In addition it gives you amazing caching ability using Redis. ISP Cache, minimizes roundtrip to Redis, 
while still giving the cached data using a JIT pattern.

This project, was a lot of fun creating. Please support it by bying a license so I can continue to improve it in future.

<iframe width="560" height="315" src="https://www.youtube.com/embed/jEAWZCYQnp4" 
frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen>
</iframe>

# roadmap for ISP Session.io
1) Performance counters
2) Command line tool to investigate session
3) Integration with MemCached (as an choice between Redis).