---
layout: post
title:  "Coaching linq"
date: 2013-09-01 13:52:38  
categories:  Coaching
---

Every once in a while I get the opportunity to coach junior developers and its something that I enjoy doing. My coaching is normally setup as a 1 hour session each week with homework. Homework is a practice exercise or task that follows and enhances the weekly sessions. If possible the sessions are in person but using video conferencing has work well in the past.

One of the topic that I cover in my coaching session is Linq and its many forms. Many students have heard of Linq but don't use it when they code and that a shame, Linq can make code more readable, enjoyable and concise.

One of the main hurdles of Linq is its 2 forms of somewhat foreign syntax.  

{% highlight csharp %}

  // Linq Query Syntax

  var result = from student in students
    where student.Scores > 95
    select student;

  // Method Chaining Syntax

  var result students.where(x => x.Scores > 95)
{% endhighlight %}

I prefer the method chaining syntax and use it exclusively. Most student like the query syntax version better because of thier exposed to SQL. Most of the homework for the Linq section revolves around querying a data set and using the summing, grouping and totaling functions. This is also a great time to reinforce some object oriented principles.

No matter what syntax you choose Linq will help make your companies code base cleaner and more maintainable. Its worth the effort to teach your junior developers. 
