fetch ('http://api.icndb.com/jokes/random/5')
    .then(
        (res) => {
            //console.log(`${res.ok}, ${res.headers}, ${res.value}, ${res.responseType}, ${res.responseText}`)
            console.log(res)
            return res.json()
        },
        (rej) => {throw new Error('\nThere was an ERRR...\n') })
        .then((body) => {
            for (let x of body.value){
                console.group(x.joke);
            }
        })
        .catch(err => { throw new Error('\nThere was a NEW ERRR...\n') })//lets test if the catch runs either way



fetch ('')//insert the http request from postman
    .then(
        (res) => {
            //console.log(`${res.ok}, ${res.headers}, ${res.value}, ${res.responseType}, ${res.responseText}`)
            console.log(res)
            return res.json()
        },
        (rej) => {throw new Error('\nThere was an ERRR...\n') })
        .then((body) => {
            for (let x of body.value){
                console.group(x.joke);
            }
        })
        .catch(err => { throw new Error('\nThere was a NEW ERRR...\n') })//lets test if the catch runs either way