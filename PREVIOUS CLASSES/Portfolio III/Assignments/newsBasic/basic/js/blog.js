// use Ajax to load the JSON file
var xhr = new XMLHttpRequest();
xhr.onload = function(){
    
    // save JSON data
   let data = JSON.parse(xhr.responseText);

   // insert the HTML articles
   // first check to make sure the blog exists
   let blogSection = document.querySelector("#blog");
   if (blogSection){
    // edit the heading
    let blogHeading = blogSection.querySelector("h2");
    if (blogHeading) {
        let heading  = 'Pokemon Starters';
        blogHeading.innerHTML = heading;
    }
    
    // console.log(data.starters[1].image);

    // edit the seperate articles by looping through the JSON file
    let htmlTemplate = "";
    for (let i = 0; i < data.starters.length; i++){    
     htmlTemplate += `
        <article>
            <p class="thumbnail">
            <img src="${data.starters[i].image}" alt="${data.starters[i].name}"></img></p>
            
            <h3>${data.starters[i].name}</h3>
            <p>${data.starters[i].pokedex}.</p>
            
            <dl>
                <dt>Type</dt>
                <dd>${data.starters[i].type}</dd>
                <dt>Ability</dt>
                <dd>${data.starters[i].ability}</dd>
                <dt>Base Stats</dt>
                <dd>${data.starters[i].base_stats}</dd>					
            </dl>
            
            <p><a href="${data.starters[i].site_link}">Read More</a></p>
        </article>
 
        `
    
    }

        // insertAdjacent is to ADD content whereas 
        // innerHTML is to REPLACE content within the HTML file
        blogHeading.insertAdjacentHTML('afterend', htmlTemplate);


        let otherGenButton = blogSection.querySelector('#blog > p');
        if (otherGenButton){
        let buttonText = "<a href='https://www.serebii.net/pokemon/all.shtml'>Other Generations</button></a>";
        otherGenButton.innerHTML = buttonText;
        
    }
    
     
   }

}

// call + close Ajax
xhr.open('GET', 'https://skyvale.github.io/pokemondata.json', true);
xhr.send(null);



