redirectToCheckout = function (sessionId) {
    var stripe = Stripe("pk_test_51O8I36CLlZ5sIs3Wy8Xm9E65Vu16MfbJwHG0HUNVZuiZTsWtSs48P7oLj1XCEUEF6zaWYBbCFYMq781h6CH9hcB400v0QxDqvN");
    stripe.redirectToCheckout({ sessionId: sessionId });
}