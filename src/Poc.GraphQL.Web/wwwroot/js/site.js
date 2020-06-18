//const apolloClient = new Apollo.lib.ApolloClient({
//	networkInterface: Apollo.lib.createNetworkInterface({
//		uri: 'https://localhost:5001/graphql'
//	})
//});

//function renderReviewsWithApollo(id) {
//	const query = Apollo.gql`
//    query reviewsForAirline($airlineId: ID!) 
//    {
//        reviews(airlineId: $airlineId) {
//            title
//            review
//        }  
//    }
//    `;

//	apolloClient
//		.query({
//            operationName: "reviewsForAirline",
//			query: query,
//            variables: { airlineId: id }
//		}).then(result => {
//			const div = document.getElementById("reviews");
//			result.data.reviews.forEach(review => {
//				div.innerHTML += `            
//                    <div class="row">
//                        <div class="col-12"><h5>${review.title}</h5></div>
//                    </div>
//                    <div class="row mb-2">
//                        <div class="col-12">${review.review}</div>
//                    </div>`;
//			});
//		});
//}

function renderReviews(id) {
	requestWithJQuery('https://localhost:44308/api/AirlineReview/',
		{
			"operationName": "reviewsForAirline",
			"query": " query reviewsForAirline($airlineId: ID!) { reviews(airlineId: $airlineId) { title review } }",
			"variables": { "airlineId": id }
		}
		, "POST", callbackAirlineReview);
}

function renderAirlines() {
	requestWithJQuery('https://localhost:44308/api/Airline/by-query?query=\"{ airlines { id name description numberOfPlanes rating logoFileName }  }\"', null, "GET", callbackAirlines);
}

function requestWithJQuery(url, param, httpVerb, success) {
	var options = {
		type: httpVerb,
		url: url,
		data: JSON.stringify(param),
		contentType: "application/json; charset=utf-8"
	};

	$.ajax(options)
		.then(data => {
			success(data);
		})
		.catch(error => {
			console.log(error);
		});
}

function callbackAirlineReview(responseGraphQL) {
	const div = document.getElementById("reviews");
	responseGraphQL.data.reviews.forEach(review => {
		div.innerHTML += `            
                    <div class="row">
                        <div class="col-12"><h5>${review.title}</h5></div>
                    </div>
                    <div class="row mb-2">
                        <div class="col-12">${review.review}</div>
                    </div>`;
	});
}

function callbackAirlines(responseGraphQL) {
	const div = document.getElementById("airlines");
	responseGraphQL.data.airlines.forEach(airline => {
		let starText = "";
		for (i = 0; i < airline.rating; i++) {
			starText += "<text>*</text>";
		}
		div.innerHTML += `  
					<div class="row">
					    <div class="col-2 text-center ml-5"><img src="Images/${airline.logoFileName}" alt="Product image" /></div>
					    <div class="col-2 my-auto"><a href="/Home/AirlineDetail?airlineId=${airline.id}">${airline.name}</a></div>
					    <div class="col-2 my-auto">${airline.numberOfPlanes}</div>
					    <div class="col-2 my-auto stars">
					        ${starText}
					    </div>

					</div>`;
	});
}