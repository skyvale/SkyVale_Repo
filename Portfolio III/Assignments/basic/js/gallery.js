// !! TODO
// For some reason, the currentImage value is incorrectly incrementing


// use Ajax to load the JSON file
var xhr = new XMLHttpRequest();
xhr.onload = function(){
    
    // save JSON data
   let data = JSON.parse(xhr.responseText);

   // first select the gallery section and
   // check to make sure the gallery section exists
   let gallerySection = document.querySelector('#gallery');

   if (gallerySection){

        // get the buttons in the html
        // let pageSection = gallerySection.querySelector('.pagination');
        // let nextButton = pageSection.getElementsByTagName('li:first-of-type');
        // let prevButton = pageSection.getElementsByTagName('li:last-of-type');

        let navButtons = document.querySelectorAll('.pagination li');
        let prevButton = navButtons[0];
        let nextButton = navButtons[1];

        // change the header
        let galleryHeading = gallerySection.querySelector('h2');
        if (galleryHeading){
            let heading = "Pokemon Wallpapers";
            galleryHeading.innerHTML = heading;
        }

        // target the article within the gallery
        let galleryArticle = gallerySection.querySelector('article');

        // create an array to hold the htmlTemplates
        let templateArray = []

        // create a loop to add the images + captions from the json file
        // (maybe you need an image array here?)
        function htmlTemplate(){

            let htmlTemplate = "";
            for (i = 0; i < data.big_images.length; i++){
                htmlTemplate = `
                    <article>
                    <p><img 
                    src="${data.big_images[i].image_link}" 
                    alt="${data.big_images[i].image_text}">
                    </p>			
                    <h3>${data.big_images[i].image_caption}</h3>
                    <p>${data.big_images[i].image_text}</p>
                    </article>
    
                `
                templateArray.push(htmlTemplate);
            }
            
            galleryHeading.insertAdjacentHTML('afterend',templateArray[0])
        }
   
        // puts the images into place
        htmlTemplate();

        // set the current image
        let getImage = 1;

        // when the user clicks the next button, it will go to the next image
        nextButton.addEventListener("click", function changeImageNext(){
            //console.log("clicked next");
            if (getImage < 5 && getImage > -1){
                // inserts the updated html into the html file
                console.log(getImage);
                gallerySection.querySelector('article').innerHTML = templateArray[getImage];
                if (getImage != 4){
                    getImage++;
                }
            }
        });

        // when the user clicks the back button, it will go back an image
        prevButton.addEventListener("click", function changeImagePrev(){
            //console.log("clicked prev");
            if (getImage < 5 && getImage > -1){
                // inserts the updated html into the html file
                console.log(getImage);
                gallerySection.querySelector('article').innerHTML = templateArray[getImage];
                if (getImage != 0){
                    getImage--;
                }
            }
        });



   }



}

// call + close Ajax
xhr.open('GET', 'https://skyvale.github.io/pokemondata.json', true);
xhr.send(null);