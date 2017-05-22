(function () {
    var gridName = 'CustomerGrid';
    var pagingUrl = 'Customer/GridPager';

    $('.grid-mvc').gridmvc();
    pageGrids[gridName].ajaxify({
        getData: pagingUrl,
        getPagedData: pagingUrl
    });
}())