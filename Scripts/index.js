/*
    2019-11-05	【BJ】ITGトップ 「IT-Guardiansのご利用シーン」オンマウス時のボタン画像が画像切れ
*/

// JavaScript Document
(function ($) {
    var $figureAreaContent = {};
    var $figureAreaContentBtn = {};
    var $figureAreaContentBtn_img = {};
    var $rolloverImages = {};
    var extensions = ['.jpg', '.jpeg', '.png', '.gif', '.svg'];
    var osrc = [];
    var hsrc = [];

    $(function () {
        $('a[href^="#a"]').click(function () {
            var speed = 800;
            var href = $(this).attr("href");
            var target = $(href == "#" || href == "" ? 'html' : href);
            var position = target.offset().top;
            $("html, body").animate({
                scrollTop: position
            }, speed, "swing");
            return false;
        });
    });

    $(function () {
        $(".localnavigation__btn").click(function () {
            $(this).next().toggleClass("is-open");
        });
    });

    $(function () {
        $(".content-inner__select-category >p").click(function () {
            $(this).next().toggleClass("is-open");
        });
    });

    //ローカルナビゲーションのホバー対策
    //$(function() {
    //	$('.localnavigation ul li a').on('mouseenter touchstart', function(){
    //         $(this).addClass('hover');
    //    }).on('mouseleave touchend', function(){
    //         $(this).removeClass('hover');
    //    });
    //});

    //rollOver Images
    function rollOver() {
        var ftype = '';
        var i = 0;
        var j = 0;

        while (i < $rolloverImages.length) {
            while (j < extensions.length) {
                ftype = extensions[j];
                var src = $rolloverImages[i].getAttribute('src');
                if (src.indexOf(ftype) !== -1) {
                    osrc[i] = src;
                    hsrc[i] = src.replace(ftype, '_o' + ftype);
                    break;
                }
                j++;
            }
            i++;
        }

        $rolloverImages.mouseover(function () {
            var ind = $rolloverImages.index(this);
            $(this).attr('src', hsrc[ind]);
        });
        $rolloverImages.mouseout(function () {
            if (!$(this).hasClass('active')) {
                var ind = $rolloverImages.index(this);
                $(this).attr('src', osrc[ind]);
            }
        });
        $rolloverImages.click(function () {
            var ind = $rolloverImages.index(this);
            this.attr('src', hsrc[ind]);
        });

    }


    /*
          figure-area-content 関係
    */

    //クローズボタンが押された時の処理
    function content_close() {
        $('.figure-area-content__close').on('click', function () {
            content_allclose();
        });
        //領域外が押されたら消える
        $(document).on('click touchend', function (event) {
            if (!$(event.target).closest('.figure-area__content').length) {
                content_allclose();
            }
        });
    }

    //figure-area-content clickが押された時の処理
    function content_click() {

        $figureAreaContentBtn.on('click', function () {

            //ポップアップを全て消す
            content_allclose();

            var $this = $(this);
            var imgObj = $this.find('.rollover');
            var ind = $rolloverImages.index(imgObj);
            imgObj.attr('src', hsrc[ind]);
            imgObj.addClass('active');

            //コンテンツ表示
            $this.parent().find('.figure-area-content').css('display', 'block');

        });
    }

    function content_allclose() {
        $figureAreaContent.css('display', 'none');

        //ボタン画像を戻す
        $figureAreaContentBtn_img.each(function () {
            var ind = $rolloverImages.index(this);
            $(this).attr('src', osrc[ind]).removeClass('active');
        });
    }


    //Trigers
    $(function () {
        $rolloverImages = $('.rollover')
        if ($rolloverImages.length) {
            rollOver();
        }

        $figureAreaContentBtn = $('.figure-area__content__btn');
        if ($figureAreaContentBtn.length) {
            $figureAreaContent = $('.figure-area-content');
            $figureAreaContentBtn_img = $('.figure-area__content__btn img');
            content_close();
            content_click();
        }


    });

})(jQuery);
