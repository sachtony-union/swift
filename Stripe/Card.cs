// Set your secret key. Remember to switch to your live secret key in production.
// See your keys here: https://dashboard.stripe.com/apikeys
StripeConfiguration.ApiKey = "sk_test_26PHem9AhJZvU623DfE1x4sd";

var options = new CardGetOptions
{
    Expand = new List<string> { "number", "cvc" },
};
var service = new CardService();
service.Get("ic_1Cm3paIyNTgGDVfzBqq1uqxR", options);
