/*  ---------------------------------------------------
Template Name: Ashion
Description: Ashion ecommerce template
Author: Colorib
Author URI: https://colorlib.com/
Version: 1.0
Created: Colorib
---------------------------------------------------------  */

'use strict';

(function ($) {

    /*------------------
        Preloader
    --------------------*/
    $(window).on('load', function () {
        $(".loader").fadeOut();
        $("#preloder").delay(200).fadeOut("slow");

        /*------------------
            Product filter
        --------------------*/
        $('.filter__controls li').on('click', function () {
            $('.filter__controls li').removeClass('active');
            $(this).addClass('active');
        });
        if ($('.property__gallery').length > 0) {
            var containerEl = document.querySelector('.property__gallery');
            var mixer = mixitup(containerEl);
        }
    });

    /*------------------
        Background Set
    --------------------*/
    $('.set-bg').each(function () {
        var bg = $(this).data('setbg');
        $(this).css('background-image', 'url(' + bg + ')');
    });

    //Search Switch
    $('.search-switch').on('click', function () {
        $('.search-model').fadeIn(400);
    });

    $('.search-close-switch').on('click', function () {
        $('.search-model').fadeOut(400, function () {
            $('#search-input').val('');
        });
    });

    //Canvas Menu
    $(".canvas__open").on('click', function () {
        $(".offcanvas-menu-wrapper").addClass("active");
        $(".offcanvas-menu-overlay").addClass("active");
    });

    $(".offcanvas-menu-overlay, .offcanvas__close").on('click', function () {
        $(".offcanvas-menu-wrapper").removeClass("active");
        $(".offcanvas-menu-overlay").removeClass("active");
    });

    /*------------------
        Navigation
    --------------------*/
    $(".header__menu").slicknav({
        prependTo: '#mobile-menu-wrap',
        allowParentLinks: true
    });

    /*------------------
        Accordin Active
    --------------------*/
    $('.collapse').on('shown.bs.collapse', function () {
        $(this).prev().addClass('active');
    });

    $('.collapse').on('hidden.bs.collapse', function () {
        $(this).prev().removeClass('active');
    });

    /*--------------------------
        Banner Slider
    ----------------------------*/
    $(".banner__slider").owlCarousel({
        loop: true,
        margin: 0,
        items: 1,
        dots: true,
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: true
    });

    /*--------------------------
        Product Details Slider
    ----------------------------*/
    $(".product__details__pic__slider").owlCarousel({
        loop: false,
        margin: 0,
        items: 1,
        dots: false,
        nav: true,
        navText: ["<i class='arrow_carrot-left'></i>", "<i class='arrow_carrot-right'></i>"],
        smartSpeed: 1200,
        autoHeight: false,
        autoplay: false,
        mouseDrag: false,
        startPosition: 'URLHash'
    }).on('changed.owl.carousel', function (event) {
        var indexNum = event.item.index + 1;
        product_thumbs(indexNum);
    });

    function product_thumbs(num) {
        var thumbs = document.querySelectorAll('.product__thumb a');
        thumbs.forEach(function (e) {
            e.classList.remove("active");
            if (e.hash.split("-")[1] == num) {
                e.classList.add("active");
            }
        })
    }


    /*------------------
        Magnific
    --------------------*/
    $('.image-popup').magnificPopup({
        type: 'image'
    });


    $(".nice-scroll").niceScroll({
        cursorborder: "",
        cursorcolor: "#dddddd",
        boxzoom: false,
        cursorwidth: 5,
        background: 'rgba(0, 0, 0, 0.2)',
        cursorborderradius: 50,
        horizrailenabled: false
    });

    /*------------------
        CountDown
    --------------------*/
    // For demo preview start
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();

    if (mm == 12) {
        mm = '01';
        yyyy = yyyy + 1;
    } else {
        mm = parseInt(mm) + 1;
        mm = String(mm).padStart(2, '0');
    }
    var timerdate = mm + '/' + dd + '/' + yyyy;
    // For demo preview end


    // Uncomment below and use your date //

    /* var timerdate = "2020/12/30" */

    $("#countdown-time").countdown(timerdate, function (event) {
        $(this).html(event.strftime("<div class='countdown__item'><span>%D</span> <p>Day</p> </div>" + "<div class='countdown__item'><span>%H</span> <p>Hour</p> </div>" + "<div class='countdown__item'><span>%M</span> <p>Min</p> </div>" + "<div class='countdown__item'><span>%S</span> <p>Sec</p> </div>"));
    });

    /*-------------------
        Range Slider
    --------------------- */
    var rangeSlider = $(".price-range"),
        //minamount = $("#minamount"),
        //maxamount = $("#maxamount"),
        amount = $('#amount'),
        minPrice = rangeSlider.data('min'),
        maxPrice = rangeSlider.data('max');
    rangeSlider.slider({
        range: true,
        min: minPrice,
        max: maxPrice,
        values: [minPrice, maxPrice],
        slide: function (event, ui) {
            amount.val('$' + ui.values[0] + ' - $' + ui.values[1])
            //minamount.val('$' + ui.values[0]);
            //maxamount.val('$' + ui.values[1]);
        }
    });
    amount.val("$" + rangeSlider.slider("values", 0) +
        " - $" + rangeSlider.slider("values", 1));
    //minamount.val('$' + rangeSlider.slider("values", 0));
    //maxamount.val('$' + rangeSlider.slider("values", 1));

    /*------------------
        Single Product
    --------------------*/
    $('.product__thumb .pt').on('click', function () {
        var imgurl = $(this).data('imgbigurl');
        var bigImg = $('.product__big__img').attr('src');
        if (imgurl != bigImg) {
            $('.product__big__img').attr({ src: imgurl });
        }
    });

    /*-------------------
        Quantity change
    --------------------- */
    var proQty = $('.pro-qty');
    proQty.prepend('<span class="dec qtybtn">-</span>');
    proQty.append('<span class="inc qtybtn">+</span>');
    proQty.on('click', '.qtybtn', function () {
        var $button = $(this);
        var oldValue = $button.parent().find('input').val();
        if ($button.hasClass('inc')) {
            var newVal = parseFloat(oldValue) + 1;
        } else {
            // Don't allow decrementing below zero
            if (oldValue > 0) {
                var newVal = parseFloat(oldValue) - 1;
            } else {
                newVal = 0;
            }
        }
        $button.parent().find('input').val(newVal);
    });

    /*-------------------
        Radio Btn
    --------------------- */
    $(".size__btn label").on('click', function () {
        $(".size__btn label").removeClass('active');
        $(this).addClass('active');
    });

    /*------------------
        My JQuery
    --------------------*/
    var filterSubmit = $('#form_submit');
    filterSubmit.on('click', function () {
        let href = filterSubmit.attr("href");
        href = href.replace(/MinPriceRange=[0-9]+/g, 'MinPriceRange=' + rangeSlider.slider("values", 0));
        href = href.replace(/MaxPriceRange=[0-9]+/g, 'MaxPriceRange=' + rangeSlider.slider("values", 1));
        let sizes = $('#size_list input[type=checkbox]:checked')
        if (sizes.length != 0) {
            href += '&Sizes='
            sizes.each(function (index) {
                if (index == 0) {
                    href += $.trim($(this).parent().text());
                } else {
                    href += ',' + $.trim($(this).parent().text());
                }
            });
        }
        let colors = $('#color_list input[type=checkbox]:checked');
        if (colors.length != 0) {
            href += '&Colors='
            colors.each(function (index) {
                if (index == 0) {
                    href += $.trim($(this).parent().text());
                } else {
                    href += ',' + $.trim($(this).parent().text());
                }
            });
        }
        filterSubmit.attr("href", href);
        $('#sidebar_form').submit();
    })

    function Util() { };

    Util.hasClass = function (el, className) {
        if ($(el).attr('class')) return el.hasClass(className);
        else return !!$(el).attr('class').match(/(\\s|^)/ + className + /(\\s|$)'/);
    };

    Util.addClass = function (el, className) {
        var classList = className.split(' ');
        if ($(el).attr('class')) $(el).addClass(classList[0]);
        else if (!Util.hasClass(el, classList[0])) $(el).addClass(classList[0]);
        if (classList.length > 1) Util.addClass(el, classList.slice(1).join(' '));
    };

    Util.removeClass = function (el, className) {
        var classList = className.split(' ');
        if ($(el).attr('class')) $(el).removeClass(classList[0]);
        else if (Util.hasClass(el, classList[0])) {
            var reg = new RegExp('(\\s|^)' + classList[0] + '(\\s|$)');
            var elementClasses = $(el).attr('class');
            elementClasses.replace(reg, ' ');
            $(el).attr('class', elementClasses)
        }
        if (classList.length > 1) Util.removeClass(el, classList.slice(1).join(' '));
    };

    var cart = $('.shopping-cart');
    if (cart.length > 0) {
        var isAnimating = false;
        let cartCount = $('.cart-count');
        let cartCountItems = $(cartCount).find('div');

        $('.add-product').click(function () {
            let imgtodrag = $(this).parent().parent().parent().parent();

            if (imgtodrag) {
                if (isAnimating) {
                    return;
                }
                isAnimating = true;

                var imgclone = imgtodrag.clone()
                    .offset({
                        top: (imgtodrag.offset().top + (imgtodrag.height() / 5)),
                        left: (imgtodrag.offset().left + (imgtodrag.width() / 5))
                    })
                    .css({
                        'opacity': '0.5',
                        'position': 'absolute',
                        'height': '150px',
                        'width': '150px',
                        'z-index': '100'
                    })
                    .appendTo($('body'))
                    .animate({
                        'top': cart.offset().top + 5,
                        'left': cart.offset().left + 5,
                        'width': 50,
                        'height': 50
                    }, 1000, 'easeInOutExpo');

                imgclone.animate({
                    'width': 0,
                    'height': 0
                }, function () {
                    $(this).detach()
                });

                setTimeout(function () {
                    updateCartCount();
                    isAnimating = false;
                }, 1100);
            }

            var this_element = $(this) // HERE
            var id = $(this_element).attr('data-itemId'); // HERE
            var parent = $(this_element).parent().parent().parent().parent().parent();
            $(parent).off('mouseenter mouseleave');
            $.ajax({
                url: 'https://localhost:7082/Cart/AddToCart/',
                type: 'POST',
                headers: {
                    "X-ANTI-FORGERY-TOKEN": $('input[name = __RequestVerificationToken]').val(),
                }
            });

        });

        function updateCartCount() {
            var actual = Number(cartCountItems[0].innerText) + 1;
            var next = actual + 1;

            Util.addClass(cartCount, 'cart-count-update');

            setTimeout(function () {
                cartCountItems[0].innerText = actual;
            }, 150);

            setTimeout(function () {
                Util.removeClass(cartCount, 'cart-count-update');
            }, 200);

            setTimeout(function () {
                cartCountItems[1].innerText = next;
            }, 230);

            isAnimating = false;
        };
    };
})(jQuery);