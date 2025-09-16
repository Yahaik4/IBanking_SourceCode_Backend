namespace src.Templates{
    public static class OTPTemplate
    {
        public static string Generate(string otp)
        {
            return $@"
                <div
                    style='
                    margin: 0;
                    font-family: ""Poppins"", sans-serif;
                    background: #ffffff;
                    font-size: 14px;
                    '
                >
                    <div
                    style='
                        max-width: 680px;
                        margin: 0 auto;
                        padding: 45px 30px 60px;
                        background: #f4f7ff;
                        background-repeat: no-repeat;
                        background-size: 800px 452px;
                        background-position: top center;
                        font-size: 14px;
                        color: #434343;
                    '
                    >
                    <main>
                        <div
                        style='
                            margin: 0;
                            margin-top: 70px;
                            padding: 92px 30px 115px;
                            background: #ffffff;
                            border-radius: 30px;
                            text-align: center;
                        '
                        >
                        <div style='width: 100%; max-width: 489px; margin: 0 auto;'>
                            <h1
                            style='
                                margin: 0;
                                font-size: 24px;
                                font-weight: 500;
                                color: #1f1f1f;
                            '
                            >
                            Your Verification Code
                            </h1>
                            <p
                            style='
                                margin: 0;
                                margin-top: 17px;
                                font-weight: 500;
                                letter-spacing: 0.56px;
                            '
                            >
                            Use the following OTP
                            to complete the procedure to change your email address. OTP is
                            valid for
                            <span style='font-weight: 600; color: #1f1f1f;'>5 minutes</span>.
                            Do not share this code with others
                            </p>
                            <p
                            style='
                                margin: 0;
                                margin-top: 60px;
                                font-size: 40px;
                                font-weight: 600;
                                letter-spacing: 25px;
                                color: #ba3d4f;
                            '
                            >
                            {otp}
                            </p>
                        </div>
                        </div>
                    </main>
                </div>
            ";
        }
    }    
}