

var instance = $('.hs__wrapper');

$.each(instance, function (key, value) {

    var arrows = $(instance[key]).find('.arrow'),
        prevArrow = arrows.filter('.arrow-prev'),
        nextArrow = arrows.filter('.arrow-next'),
        box = $(instance[key]).find(".hs"),
        x = 0,
        mx = 0,
        maxScrollWidth = box[0].scrollWidth - (box[0].clientWidth / 2) - (box.width() / 2);

    $(arrows).on('click', function () {

        if ($(this).hasClass("arrow-next")) {
            x = ((box.width() / 2)) + box.scrollLeft() - 10;
            box.animate({
                scrollLeft: x,
            })
        } else {
            x = ((box.width() / 2)) - box.scrollLeft() - 10;
            box.animate({
                scrollLeft: -x,
            })
        }

    });

    $(box).on({
        mousemove: function (e) {
            var mx2 = e.pageX - this.offsetLeft;
            if (mx) this.scrollLeft = this.sx + mx - mx2;

        },
        mousedown: function (e) {
            this.sx = this.scrollLeft;
            mx = e.pageX - this.offsetLeft;
        },
    });

    $(document).on("mouseup", function () {
        mx = 0;
    });

    // let num = 0;
    var bool = true;


    function running() {
        if (bool) {
            x = box.scrollLeft() + 100;
            box.animate({
                scrollLeft: x,
            })
            // if (num = 6) {
            //     num = 0;
            // }
            // num = 0;
            // num++;
            if(box.scrollLeft() > 500) {
                bool = false;
            }
        }
        else {
            x = box.scrollLeft() - 100;
            box.animate({
                scrollLeft: x,
            })
            // num--;
            if(box.scrollLeft() == 0) {
                bool = true;
            }
            
            // if (num = 6) {
            //     num = 12;
            // }
        }

    };

    var timer = setInterval(running, 1000);

    $('.hs').hover(function(){
        clearInterval(timer);
    }, function() {
        timer = setInterval(running, 1000);
    });

    
    // $(box).mouseover(function() {
    //     console.log('test');
    //     clearInterval(timer)
    // })
});

// var num = 0;
// var numd = 0;
// var timer = null;
// running();
// function running() {
//     timer = setInterval(function() {
//         if(num > 9) {
//             num = 0;
//             $('.hs').css(
//                 "left", "0"
//             );
//         }
//         $('.hs').animate({"left":(-50*num)+"px"}, 180);
//         num++;
//     }, 1000);
// };