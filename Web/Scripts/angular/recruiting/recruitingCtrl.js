app.controller('recruitingCtrl', ['$scope', function ($scope) {

    var colorClassMapping = {
        "Death Knight": "#C41E3B",
        "Druid": "#FF7C0A",
        "Hunter": "#AAD372",
        "Mage": "#68CCEF",
        "Monk": "#008467",
        "Paladin": "#F48CBA",
        "Priest": "#FFFFFF",
        "Rogue": "#FFF468",
        "Shaman": "#2359FF",
        "Warlock": "#9382C9",
        "Warrior": "#C69B6D"
    };

    var colorPriorityMapping = {
        "High": "#FF420E",
        "Medium": "#FFD320",
        "Low": "#1EF1A2"
    }

    var currentRecruitment = [
        {
            Class: "Death Knight",
            Spec: "Blood",
            ClassColor: colorClassMapping["Death Knight"],
            Icon: "icon-deathknight.jpg",
            Priority: "High",
            PriorityColor: colorPriorityMapping["High"]
        },
        {
            Class: "Druid",
            Spec: "Balance",
            ClassColor: colorClassMapping["Druid"],
            Icon: "icon-druid.jpg",
            Priority: "Low",
            PriorityColor: colorPriorityMapping["Low"]
        },
        {
            Class: "Paladin",
            Spec: "Holy",
            ClassColor: colorClassMapping["Paladin"],
            Icon: "icon-paladin.jpg",
            Priority: "Medium",
            PriorityColor: colorPriorityMapping["Medium"]
        },
        {
            Class: "Warlock",
            ClassColor: colorClassMapping["Warlock"],
            Icon: "icon-warlock.jpg",
            Priority: "Low",
            PriorityColor: colorPriorityMapping["Low"]
        }
    ];

    $scope.recruitmentClasses = currentRecruitment;

}]);