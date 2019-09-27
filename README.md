# Dungeons & Dragons Campaign Manager

### About
This is an in-development project to create a web application to manage Dungeons & Dragons campaigns. This project is still in very early development.

### Technology
- .NET Core 3.0
- Blazor
- Some Db Provider
  - Using SQL for development purposes
  - Using EF Core to work with the db

### UI Design
This section describes the current planned page map. Probably will change 568 times.

##### Login
Users will be routed to this page if they are not logged in. Users cannot access any of the pages in this app (besides the auto-generated auth pages) if they are not logged in.

##### Dashboard
The default Index.razor page if user is logged in. Have a newsfeed of recent activities for everyone. There's not going to be a concept of "following" people for now so it's just going to show everyone's activity across the app. Will also show current campaigns and characters that the logged-in user is participating in. Lots of navigation to places.

##### Profile
View current and past campaigns and characters. View your personal activity. Have a profile picture & some contact info for funsies.

##### Create a Character
Create a character wizard.

##### Create a Campaign
Create a campaign wizard.

##### View Campaign
Shows character summaries and a lot of text describing what has happened so far in the campaign. The idea is that the DM would write a summary after every game explaining what happened. Other characters can also contribute notes which will be viewable somehow. Not sure exactly how to organize this yet.

### Resources
http://www.dnd5eapi.co/docs/

















