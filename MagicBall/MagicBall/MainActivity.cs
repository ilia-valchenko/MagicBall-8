using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using Android.Hardware;
using Android.Runtime;

namespace MagicBall
{
    [Activity(Label = "Magic Ball 8", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ISensorEventListener
    {
        #region ISensorEventListener implementation
        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            throw new NotImplementedException();
        }

        public void OnSensorChanged(SensorEvent e)
        {
            throw new NotImplementedException();
        } 
        #endregion

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            List<string> answers = new List<string>
            {
                // affirmative
                "It is certain!\n(Бесспорно!)",
                "It is decidedly so.\n(Предрешено.)",
                "Without a doubt.\n(Никаких сомнений.)",
                "Yes, definitely.\n(Определённо да.)",
                "You may rely on it.\n(Можешь быть уверен в этом.)",
                "As I see it, yes.\n(Мне кажется — «да».)",
                "Most likely.\n(Вероятнее всего.)",
                "Outlook good.\n(Хорошие перспективы.)",
                "Yes.\n(Да.)",
                "Signs point to yes.\n(Знаки говорят — «да».)",
                // non-committa
                "Reply hazy try again.\n(Пока не ясно, попробуй снова.)",
                "Ask again later.(Спроси позже.)",
                "Better not tell you now.\n(Лучше не рассказывать.)",
                "Cannot predict now.(Сейчас нельзя предсказать.)",
                "Concentrate and ask again.\n(Сконцентрируйся и спроси опять.)",
                // negative
                "Don't count on it!\n(Даже не думай!)",
                "My reply is no.\n(Мой ответ — «нет».)",
                "My sources say no.\n(По моим данным — «нет».)",
                "Outlook not so good.\n(Перспективы не очень хорошие.)",
                "Very doubtful.\n(Весьма сомнительно.)"
            };

            SetContentView (Resource.Layout.Main);

            Button askButton = FindViewById<Button>(Resource.Id.askButton);
            TextView answerTextView = FindViewById<TextView>(Resource.Id.answerTextView);
            Random random = new Random();

            askButton.Click += delegate
            {
                int randomIndex = random.Next(answers.Count);
                answerTextView.Text = answers[randomIndex];
            };
        }

        // add some interesting feature
        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}

