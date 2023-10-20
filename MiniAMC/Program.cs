

using MiniAMC.Models;

Console.WriteLine("Adding Products.");


insertentProduct();
insertStatus();
insertAppraisal();
insertProduct();



//Methods
static void insertentProduct()
{
    using (var db = new Context())
    {
        for (int i = 5; i <= 15; i++)
        {
            Comment comment1 = new Comment();
            comment1.AppraisalId = i;
            comment1.Text = "Comment 1 on Appraisal " + i;
            comment1.CommentDate = DateTime.Now;

            db.Comment.Add(comment1);

            Comment comment2 = new Comment();
            comment2.AppraisalId = i;
            comment2.Text = "Comment 2 on Appraisal " + i;
            comment2.CommentDate = DateTime.Now;

            db.Comment.Add(comment2);
        }
        db.SaveChanges();
    }
}

static void insertProduct()
{
    using (var db = new Context())
    {
        Product product = new Product();
        product.Name = "1004D";
        product.Description = "This is 1004D product.";
        product.Price = 20;

        db.Product.Add(product);

        db.SaveChanges();
    }
}

static void insertStatus()
{
    using (var db = new Context())
    {
        Status status1 = new Status();
        status1.Name = "InProgress";
        status1.Description = "InProgress";

        db.Status.Add(status1);

        Status status2 = new Status();
        status2.Name = "New";
        status2.Description = "New";

        db.Status.Add(status2);

        Status status3 = new Status();
        status3.Name = "Completed";
        status3.Description = "Completed";

        db.Status.Add(status3);

        db.SaveChanges();
    }

    return;
}

static void insertAppraisal()
{
    using (var db = new Context())
    {
        for (int i = 0; i < 10; i++)
        {
            Appraisal appraisal = new Appraisal();
            appraisal.AppraisalValue = 5000;
            appraisal.AppraisalDate = DateTime.Now;
            appraisal.PropertyAddress = "House BA Street AZ";
            appraisal.ProductId = 1;
            appraisal.StatusId = 1;


            db.Appraisal.Add(appraisal);
        }

        db.SaveChanges();
    }

    return;
}
