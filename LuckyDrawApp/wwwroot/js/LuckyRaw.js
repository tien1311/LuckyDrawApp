$(document).ready(function () {
    var tMax = 10000, // animation time, ms
        height = 700,
        speeds = [],
        r = [],
        target = 7381250150310,
        winner = 'KH1234',
        sTarget = target.toString(),
        numberOutput = [],
        reels = [
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0'],
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0']
        ],
        $reels,
        start;

    function init() {
        $reels = $('.reel').each(function (i, el) {
            el.innerHTML = '<div class="reel-holder"><p>' + reels[i].join('</p><p>') + '</p></div><div class="reel-holder"><p>' + reels[i].join('</p><p>') + '</p></div><div class="reel-door">?</div>'
        });

        $('.lever').click(action);
    }

    function action() {
        var CreatedBy = document.getElementById("CreatedBy").value;
    
        var LuckyDrawId = document.getElementById("luckyDrawId").value;
      
        var LuckyDrawPrizeId = document.getElementById("luckyDrawPrizeId").value;
        console.log(LuckyDrawPrizeId);
        $.ajax({
            type: "POST",
            headers: {
                'x-functions-key': 'nHQesVUD5bA/pgSa7/PvF6neTvGdxiROTetNeEh6Stt4mgqZPhj15g==',
                'Content-Type': 'application/json'
            },
            url: "https://ev-services.azurewebsites.net/api/luckydraw/draw",
            data: JSON.stringify({
                "createdBy": CreatedBy,
                "luckyDrawId": LuckyDrawId,
                "luckyDrawPrizeId": LuckyDrawPrizeId
            }),
            success: function (result) {
                console.log(result);
                target = result.drawData;
                sTarget = target.toString();
                winner = result.agentId;
                
                console.log(target);
                console.log(winner);

                if (start !== undefined) return;

                $('.reel-door').fadeOut(100);
                $('.lever').attr('disabled', true)
                    .addClass('button-inactive')
                    .text('Good luck!');
                for (var i = 0, len = sTarget.length; i < len; i++) {
                    var intOffset = (parseInt(+sTarget.charAt(i) | 0)) * height / 10 - ((height / 10) * 2);
                    numberOutput[i] = intOffset >= 0 ? intOffset : (height - (height / 10));
                    if (sTarget.charAt(i) == 0) {
                        numberOutput[i] = numberOutput[i] - (height / 10);
                    }
                }
                for (var j = 0; j < 13; ++j) {
                    speeds[j] = Math.random() + .7;
                    r[j] = (Math.random() * 10 | 0) * height / 10;
                }
                animate();
            },
        });
    }

    function animate(now) {
        if (!start) start = now;
        var t = now - start || 0;

        for (var i = 0; i < 13; ++i)
            $reels[i].scrollTop = (speeds[i] / tMax / 3 * (tMax - t) * (tMax - t) + numberOutput[i]) % height | 0;
        if (t < tMax) {
            requestAnimationFrame(animate);
        } else {
            start = undefined;
            check();
        }
    }
    function check() {
        for (var i = 0, len = sTarget.length; i < len; i += 1) {
            $('.reel:eq(' + i + '), .fake-reel:eq(' + i + ')').addClass('match');
        }

        var announcement;
        announcement = 'Xin chúc mừng bạn đã trúng giải';

        $('.js-announcement').text(announcement);
        $('#agentId').text(winner+' - Phòng vé ABC');
        $('.lever').text('-');
    }

    init();
});