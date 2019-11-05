// !! TODO
// Get the images to change when buttons are clicked:
//      - try looping through the htmlTemplate when the buttons are clicked


// use Ajax to load the JSON file
var xhr = new XMLHttpRequest();
xhr.onload = function(){
    
    // save JSON data
   let data = JSON.parse(xhr.responseText);

   // first select the gallery section and
   // check to make sure the gallery section exists
   let gallerySection = document.querySelector('#gallery');
   if (gallerySection){

        // VARIABLES THAT YOU MIGHT NEED
        let pageSection = gallerySection.querySelector('#pagination');
        let activeArticle;
        let articles = document.querySelectorAll('article');

        // THESE BOIS DONT WORK
        // let nextButton = pageSection.querySelector('li:first-of-type');
        // let prevButton = pageSection.querySelector('li:last-of-type');

        
        // change the header
        let galleryHeading = gallerySection.querySelector('h2');
        if (galleryHeading){
            let heading = "Pokemon Wallpapers";
            galleryHeading.innerHTML = heading;
        }

        // target the article within the gallery
        let galleryArticle = gallerySection.querySelector('article');

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
            }
        }

        console.log(htmlTemplate);
        // inserts the updated html into the html file
        galleryArticle.innerHTML = htmlTemplate;

        //galleryHeading.insertAdjacentHTML('afterend',htmlTemplate);
   
        // when the user clicks the next button, it will go to the next image
        nextButton.addEventListener("click",changeImageNext);

        // when the user clicks the back button, it will go back an image
        prevButton.addEventListener("click",changeImagePrev);

        // add a function that changes the image forward
        // * make sure it resets to the beginning of the images
        function changeImageNext(event){

            for (i = 0; i < articles.length; i++){
                // console.log(articles[i]+ " " + i);
                activeArticle = articles[i + 1];
                
            }
        }

        // THIS PROBABLY WONT WORK
        // add a function that changes the image backward
        // * make sure it resets to the end of the images
        function changeImagePrev(event){

            for (i = articles.length - 1; i < articles.length; i--){
                // console.log(articles[i]+ " " + i);
                activeArticle = articles[i - 1];
                
            }
        }
   }



}

// call + close Ajax
xhr.open('GET', 'https://skyvale.github.io/pokemondata.json', true);
xhr.send(null);