---
layout: post
title:  "Empty a SharePoint Recycle Bin"
date:   2013-04-03 13:52:38
categories: sharepoint
---

I have the luxury of working on a locked down SharePoint farm for a large financial institution. To say that it's frustrating would be an understatement.No code allowed, installing stuff or fun. So what do you do when you're locked out? Grab your lock picking tool, PowerShell, and start scripting.

{% highlight powershell %}
$url = "http://sharepoint/sites/mysitecollection/_layouts/AdminRecycleBin.aspx"
$cred = Get-Credential

$page = Invoke-WebRequest -URI $url -Credential $cred -SessionVariable sp

$page.forms["usrpage"].Fields["actionID"] = "Empty"

$finished = Invoke-WebRequest $url -WebSession $sp -Body $page.forms["usrpage"] -Method Post
{% endhighlight %}

_Use this script at your own risk._