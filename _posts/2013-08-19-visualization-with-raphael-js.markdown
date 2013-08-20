---
layout: post
title:  "Visualization with Raphael.js"
date:   2013-08-19 4:14:22
categories: blog
---

I've been having a lot of fun lately building custom visualization with [Raphael.js]. My latest project is a dashboard for a globally distributed call center with near real-time data feeds. Making new and interesting visualizations with this library is a breeze and my client thinks they are sexy!

## Raphael.js 

> Raphaël uses the SVG W3C Recommendation and VML as a base for creating graphics. This means every graphical object you create is also a DOM object, so you can attach JavaScript event handlers or modify them later. Raphaël’s goal is to provide an adapter that will make drawing vector art compatible  cross-browser and easy. Raphaël currently supports Firefox 3.0+, Safari 3.0+, Chrome 5.0+, Opera 9.5+ and Internet Explorer 6.0+.

## The Timeline

Working with a globally dispersed call center data is challenging. The most challenging aspect is dealing with the UX and UI of time zone sensitive data. We all know the pain of trying to coordinate a meeting with people dispersed across the US but have you tried to do that with offshore workers also. Let's just say, it's not fun. 

One of the ways you can display this information is with the "x hours ago" method. Here in this new timeline control. You can see how I use it to display some naughty reports on a particular call center employee.

![Raphael.js Timeline]({{ site.url }}/assets/images/raphael-timeline.png)

With Raphael and Angular this timeline is easy to build and is visually appealing. If you use the same reference timezone the "x hr ago" on the scale will work in every timezone in the world. I always use UTC time for a reference time.

## The Schedule

In a call center schedule adherence is a big deal. We could have displayed the actual and planned schedule in a table and let the manager decide. Or we could go the extra mile and give them a nicer visualization like this.

![Raphael.js Schedule]({{ site.url }}/assets/images/raphael-schedule.png)

With [Raphael.js] the flags are easy to draw by hand or you can export the paths from Adobe Illustrator or other vector graphics applications and use them with Raphael. Once you have the paths rotating them on the horizon to represent the "Actual" schedule or "Plan", is easy.  

## Gauges - got to love them!

What's not to love? Well, the math for drawing arcs is a little painful.

![Raphael.js Gauge]({{ site.url }}/assets/images/raphael-gauge.png)

The best part of making your own gauges is the ability to customize every aspect of the look and feel. My client wants color sections, multiple thumbs and animations.

## Metro Bricks
Ok, you don't need [Raphael.js] for this UI. Div's and CSS will get the job done and is easy to do. If you need the rounded corners and your client base is IE8, then Raphael is going to be an option.

![Raphael.js Metro]({{ site.url }}/assets/images/raphael-metro.png)

## Conclusion
[Raphael.js] is a very powerful JavaScript library and its use of VML is well supported by a wide variety of browsers. My project requires that it works on IE8 and to be usable on mobile devices like the Surface and Blackberry phones. That's a tall order but with Raphael if it works in IE8, then it works on mobile.

Not every project is going to need custom visualization but when they do, give [Raphael.js] a try.


[Raphael.js]: http://raphaeljs.com/
[Angular.js]: http://angularjs.org/