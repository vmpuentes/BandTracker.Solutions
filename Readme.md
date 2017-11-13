# BandTracker:C# Week 4 Project November 2017

#### _ 11.3.17_

#### By _**Victor M. Puentes Jr**

## Description

_An app that will let a user track bands and the venues where they've played concerts. retrieve a band's name and the venues that each band has performed at. The user will also be able to assign a venue to a band and/or band to a venue and retrieve details about the band and the venue the band performs.


## Specifications

| Behavior  | Input  | Output  |
|---|---|---|
|1.user can click on views button for bands on homepage, a list of all the bands will be displayed. | User clicks button | Bands are displayed on bands details page.|
|2. User may enter a new band's information and see it in the band's details page | User Enters info of favorite band | favorite band's info is appended |
|3. User may see a list of all venues | click all venues button | all available venues are appended. |
|4. User may enter a new venue and a form will appear to enter the venue's info | venue form is filled out. | venue info is displayed. |
|5. User is able to add a venue to a band of their choosing. | a
form to add bands will appear. | User's chosen band is added to venue.|
|6. User see details of venue. | Venue is selected | Venue details are appended. |
|7. User is able to update details of venue and add a band. | user clicks on venue, and adds a band that has performed there. | Band is displayed on venue details page. |

## Getting Started

May be deployed using git hub at  https://vmpuentes.github.com/HairSalon.Solutions/.

### Installation/Setup Requirements
1.This app may be cloned at  https://vmpuentes.github.com/HairSalon.Solutions/.
2. Set up .NET dependencies
3. Set up database with MAMP and create a database with these instructions...

## Database Setup
> CREATE DATABASE band_tracker;
> USE band_tracker;
> CREATE TABLE bands (id serial PRIMARY KEY, name VARCHAR(255), aka VARCHAR(255), origin VARCHAR(255), members VARCHAR(255), genres VARCHAR(255));
> CREATE TABLE venues (id serial PRIMARY KEY, name VARCHAR(255), location VARCHAR(255));

> CREATE TABLE bands_venues (id serial PRIMARY KEY, band_id INT, venue_id INT);

## Built With

* [C#](https://learnhowtoprogram.com/couses/c#)
* .NET Framework
* MVC
* [HTML5](https://developer.mozilla.org/en-US/docs/Web/Guide/HTML/HTML5) - Used to contruct this webpage
* [CSS3](http://html.com/css/) - Used to style
* [Javascript] (https://www.javascript.com/) - Used for user interactives
* [Bootstrap](http://getbootstrap.com/) - CSS library used

## Author

 **Victor M. Puentes Jr.** - *Initial work* - [github user name: vmpuentes](https://github.com/vmpuentes)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Epicodus (https://epicodus.com/)
* free Code Camp (https://freecodecamp.com/)
* Software Engineering Daily (https://softwareengineeringdaily.com/)
