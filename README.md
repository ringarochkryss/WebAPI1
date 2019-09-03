# WebAPI1 

<img src= "WebAPI1/karamellbrand logo.jpg?raw=true" width="70">

https://ringarochkryss.github.io/WebAPI1/

---

### Description
This is a Web Service Api in .Net C# with a xml-data source containing information about Books.<br/> 
The service provides data as json.



---
### Content
The service provides the following: 
* GET all books *.../api/books
* Get search for Author *.../api/books?author=author
* GET search for Title  *.../api/books?title=title
* GET search for Genre   *.../api/books?genre?genre

---

### Users / Target Group 
* Any client or user who want to search for these books 

---

### Api Setup
This is how the Api is organized:

#### Models
* BookRepository -Using Xdocument to fetch data from the Xml-file and bring into a list
* IBookRepository - Get All method
* Book.cs specifying all elements of the Book to be passed along:
  * Id
  * Author 
  * Title 
  * Genre 
  * Price 
  * Publish Date 
  * Description
  
#### Controllers
* BookController -return repository GetAll (books) and the search methods.
* HomeController -return View and show data
* Catchefilter -to speed up user experience


### Frontend
This Web Api is with MVC and a simple Html demonstration is included.
The Views contains:
* Layout page (html) -links to the AppStart/bundleconfig libraries such as Jquery, Bootstrap and Linq,
and a simple layout.
* Viewstart (html) -This html is loaded with a hidden table (with all the books) and a search input 
provides the possibility to search for book title, authors or genre.

Also this html displays the web api paths for "get all books" and the search functions with examples.
Pressing buttons with examples displays json data sent form this Web Api.

The Html is supported by a JS-file with Jquery (Bookscript) pointing to the Web Service URI:s. 

A index html page displays the content from these files.

---

### Languages Libraries and Tecniques
* html5 
* Css
* Bootstrap 4 
* Jquery 
* Linq
* Ajax
* C#
* Javascript

---

### Technologies used 
#### [Visual Studio](https://visualstudio.microsoft.com/) 
#### [Git Hub](https://github.com/) 
#### [W3 Validator](https://validator.w3.org/) -Html & CSS
#### [Font Awsome](https://fontawesome.com/)
#### [Google Fonts](https://fonts.google.com/)
#### [Chrome Inspector Tools](https://www.google.com/chrome/)
#### [Bootstrap 4](https://getbootstrap.com/)
#### [Jquery](https://jquery.com/)

---

### Testing
* Functionality Manual Testing of buttons and links 
  * Pointing to the right source
  * not throwing an error
  * external sites is opened as "Target blank"
  * All buttons and links displayed properly in different sizes of Viewports
  * Inspect collapsed behaviour to see it matches expectations in all Viewports
* Functionality Manual Testing of hover-effects
  * Test functionality to work and be logical for the user
  * Test usability and make sure it's not slowing down the functionality
* Functionality Manual Testing of Responsiveness (Chrome inspector tools)
  * Test all above on different Viewports
* Code validation Html -W3 Validator
* Code validation CSS -W3 Validator
* Chrome Developer Tools


### Bugs & Errors during testing
   * When displaying Books publish date: Time should not be displayed in frontend table -only date.
   * Data is repeated multiple times in replys from the web service
   * When search input is empty -the table should be hidden
   
   
#### Solutions & Analysis 
   * The Datetime sent from the web service is correct. To display it without time in the frontend 
        would improve readability and give a more professional impression.
   * The issue with displaying repeated data needs to be tracked to the right source. The number of repeats varies
        and that should indicate where to look for a solution. 
   * When user types in input field -the table findings is displayed. But if the user earase all text in input 
     -the whole table should be hidden again. Instead the table is displayed with all data items.  
       User can manually hide the table by pushing a button however this is not good enough ux. 

---

### Endpoints
Learn more about [endpoints](https://teamtreehouse.com/community/what-is-an-api-endpoint)

---

### Deployment
As a "user page" the repository on Github can only be published from the master branch.

To configure a publishing source for Github Pages:  
1. Go to the github repository
2. Click on Settings
3. In Select Source drop-down- select master branch
4. Save

---

### Contributing
1. Fork this repository to your account.
2. Clone your repository git clone https://ringarochkryss.github.io/WebAPI1
3. Commit changes git commit -m "description of changes"
4. Push to the remote branch: git push origin new-feature
5. Open a pull request
---
### Suggested Contribution
*  This Web Api Controller uses this construction for searh: t => string.Equals(t.Title, title,
   Is it possible to use a string.Contains... and if so how?
*  Tracking down the duplicate-issue and solve it.
---

### Acknowledgements
Acknowledgements to [Microsoft] (https://docs.microsoft.com/)
 


### Installation
---
### License
---

With great support from:
Mentor: :star: @ivanprgomet  
@Sigma ITC Malmö


made by: Petra Mellbrand 2019 
:sweden:
