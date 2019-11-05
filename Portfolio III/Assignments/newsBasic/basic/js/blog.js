document.querySelector("#blog h2").innerHTML = "Pokemon Starters";

// use Ajax to load the JSON file
var xhr = new XMLHttpRequest();
xhr.onload = function(){
    
    // save JSON data
    let data = JSON.parse(xhr.responseText);

    // insert the HTML articles

   let htmlTemplate = "";
   for (let i = 0; i < data.starters.length; i++){    
    starterMon = `
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

       htmlTemplate += starterMon;
   }
   
   // let blogSection = document.querySelector("#blog");
   document.getElementById("blog").innerHTML = "<h2>Pokemon Starters</h2>"+htmlTemplate+"<p><a href='https://www.serebii.net/pokemon/all.shtml'><button>Other Generations</button></a></p>";
   
}

// call + close Ajax
xhr.open('GET', 'https://skyvale.github.io/pokemondata.json', true);
xhr.send(null);



