# Date Formatter

This project contains a date formatter that currently formats only into the Last Seen format. Last seen formats works as follows. Given two dates (lastActiveDate and DateTime.Now) the strings produced are the following:

- **Just Now**: If time difference is less than a minute
- **Minutes ago**: If time difference is more than 1 minute, less than 5
- **Less than an hour ago**: If time difference is more than 5 minutes and less than 30
- **n Hours ago**: If time difference is more than 1 hour
- **n Days ago**: If time difference is more than 1 day

## Getting Started

Nothing special. Just clone the repo and build to get the Nuget packages required to restore itself. (NUnit and Moq)

### How to use

Clone the repo

```
git clone https://github.com/MDK-Studio/Date-Formatter.git
```

Add The DateFormatter project to your solutions

```
Right-click your project solution -> Add -> Existing Project
Browse to DateFormatter and select the project.
```

Once added the last seen functionality can be used as follows.

```
using FormatHelper;

...

var dateFormatter = new DateFormatter();
var formattedString = dateFormatter.GetLastSeenFormat(lastActiveDate,
                                                      DateTime.Now);

```
An interface is also included, which can be registered in you IoC and injected where needed. When injected use the formatter as follows.

```
var formattedString = _dateFormatter.dateFormatter.GetLastSeenFormat(lastActiveDate, DateTime.Now);

```

## Running the tests

With Resharper installed you can run the tests by pressing Ctrl+T followed by Ctrl+L. Otherwise use any other test runner in Visual Studio that you preffer.

## Authors

* **Dane Mackier**

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
