app.controller('recruitmentCtrl', ['$scope', function ($scope) {

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
            Class: "Monk",
            Spec: "Mistweaver",
            ClassColor: colorClassMapping["Monk"],
            Icon: "class-icon-monk.jpg",
            Priority: "High",
            PriorityColor: colorPriorityMapping["High"]
        },
        {
            Class: "Druid",
            Spec: "Restoration",
            ClassColor: colorClassMapping["Druid"],
            Icon: "class-icon-druid.jpg",
            Priority: "High",
            PriorityColor: colorPriorityMapping["High"]
        },
        {
            Class: "Priest",
            Spec: "Holy",
            ClassColor: colorClassMapping["Priest"],
            Icon: "class-icon-priest.jpg",
            Priority: "High",
            PriorityColor: colorPriorityMapping["High"]
        },
        {
            Class: "Shaman",
            Spec: "Restoration",
            ClassColor: colorClassMapping["Shaman"],
            Icon: "class-icon-shaman.jpg",
            Priority: "High",
            PriorityColor: colorPriorityMapping["High"]
        }
    ];

    $scope.recruitmentClasses = currentRecruitment;

}]);