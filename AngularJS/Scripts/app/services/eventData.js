eventsApp.factory('eventData', function ($http, $q, $log) {
    return {
        event: {
            name: 'Angular Boot Camp',
            date: '1/1/2013',
            time: '10:30 am',
            location: {
                address: 'Google Headquarters',
                city: 'Mountain View',
                province: 'CA'
            },
            imageUrl: '/Content/Images/angularjs-logo.png',
            sessions: [
                {
                    name: 'Directives Masterclass',
                    creatorName: 'Bob Smith',
                    duration: 1,
                    level: 'Advanced',
                    abstract: 'In this sesison you will learn the ins and outs of directives!',
                    upVoteCount: 0
                },
                {
                    name: 'Scopes for fun and profit',
                    creatorName: 'John Doe',
                    duration: 2,
                    level: 'Introductory',
                    abstract: 'This session will take a closer look at scopes.  Learn what they do, how they do it, and how to get them to do it for you.',
                    upVoteCount: 3
                },
                {
                    name: 'Well Behaved Controllers',
                    creatorName: 'Jane Doe',
                    duration: 4,
                    level: 'Intermediate',
                    abstract: 'Controllers are the beginning of everything Angular does.  Learn how to craft controllers that will win the respect of your friends and neighbors.',
                    upVoteCount: 0
                }
            ]
        },

        //getEvent: function () {
        //    var deferred = $q.defer();

        //    $http({ method: 'GET', url: '/Event/Get/1' }).
        //      success(function (data, status, headers, config) {
        //          // this callback will be called asynchronously
        //          // when the response is available
        //          $log.info(data)
        //          deferred.resolve(data);
        //      }).
        //      error(function (data, status, headers, config) {
        //          // called asynchronously if an error occurs
        //          // or server returns response with an error status.
        //          deferred.reject(status);
        //      });

        //    return deferred.promise;
        //}
    };
});